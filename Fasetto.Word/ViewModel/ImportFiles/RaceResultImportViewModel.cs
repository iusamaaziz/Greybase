using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

using ExcelDataReader;

using GreyBase.DataModels;
using GreyBase.Models;
using GreyBase.ValueConvertors;

using Microsoft.Win32;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class RaceResultImportViewModel : BaseViewModel
	{
		#region Public Properties

		public ObservableCollection<RaceResultImportModel> Models { get; set; } = new ObservableCollection<RaceResultImportModel>();

		public string SelectedFileName { get; set; } = "No File Selected.";

		public List<string> Sheets { get; set; } = new List<string>();

		public int SelectedSheetIndex { get; set; } = -1;

		public DataTableCollection tableCollection { get; set; }

		#endregion

		#region Public Commands

		/// <summary>
		/// Opens the current message thread
		/// </summary>
		public ICommand BrowseFileCommand { get; set; }

		public ICommand SheetSelectedCommand { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public RaceResultImportViewModel()
		{
			// Create commands
			BrowseFileCommand = new RelayCommand(BrowseFile);
			SheetSelectedCommand = new RelayCommand(SheetSelected);
		}

		#endregion

		#region Command Methods

		public void BrowseFile()
		{
			OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" };
			ofd.Title = "Select Race Result File";
			if ((bool)ofd.ShowDialog())
			{
				SelectedFileName = ofd.FileName;
				OnPropertyChanged(nameof(SelectedFileName));
				try
				{
					using (FileStream stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
					{
						using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
						{
							DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
							{
								ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
							});
							tableCollection = result.Tables;
							Sheets.Clear();
							foreach (DataTable item in result.Tables)
							{
								Sheets.Add(item.TableName);
							}
						}
						OnPropertyChanged(nameof(Sheets));
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Application.Current.MainWindow.Title);
				}
			}
		}

		public void SheetSelected()
		{
			Models.Clear();
			System.Data.DataTable dt = tableCollection[SelectedSheetIndex];
			if (dt != null)
			{
				List<RaceResultImportModel> customers = new List<RaceResultImportModel>();
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					string complete = dt.Rows[i][2]?.ToString();
					string[] time = complete.Split(' ');

					string s = $"{dt.Rows[i][0].ToString().Split(' ')?.First()} {time?.First()}";
					DateTime t = DateTime.ParseExact(s, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

					RaceResultImportModel c = new RaceResultImportModel()
					{
						Date = t,
						Track = dt.Rows[i][1]?.ToString(),
						Grade = time?.ElementAt(1),
						Distance = time?.ElementAt(2),
						FirstPos = $"Trap{dt.Rows[i][3]}",
						FirstDog = dt.Rows[i][4]?.ToString(),
						FirstBsp = dt.Rows[i][5]?.ToString(),
						FirstIsp = dt.Rows[i][6]?.ToString(),
						SecondPos = $"Trap{dt.Rows[i][7]}",
						SecondDog = dt.Rows[i][8]?.ToString(),
						SecondBsp = dt.Rows[i][9]?.ToString(),
						SecondIsp = dt.Rows[i][10]?.ToString(),
						ThirdPos = $"Trap{dt.Rows[i][11]}",
						ThirdDog = dt.Rows[i][12]?.ToString(),
						ThirdBsp = dt.Rows[i][13]?.ToString(),
						ThirdIsp = dt.Rows[i][14]?.ToString(),
						ForthPos = $"Trap{dt.Rows[i][15]}",
						ForthDog = dt.Rows[i][16]?.ToString(),
						ForthBsp = dt.Rows[i][17]?.ToString(),
						ForthIsp = dt.Rows[i][18]?.ToString(),
						FifthPos = $"Trap{dt.Rows[i][19]}",
						FifthDog = dt.Rows[i][20]?.ToString(),
						FifthBsp = dt.Rows[i][21]?.ToString(),
						FifthIsp = dt.Rows[i][22]?.ToString(),
						SixthPos = $"Trap{dt.Rows[i][23]}",
						SixthDog = dt.Rows[i][24]?.ToString(),
						SixthBsp = dt.Rows[i][25]?.ToString(),
						SixthIsp = dt.Rows[i][26]?.ToString(),
					};
					Models.Add(c);
				}
				OnPropertyChanged(nameof(Models));
			}

			ImportHelper.ConvertImport(Models.ToList());
		}

		#endregion
	}
}

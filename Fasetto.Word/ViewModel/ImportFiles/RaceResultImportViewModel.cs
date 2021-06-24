using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

using GreyBase.DataModels;
using GreyBase.Models;

using Microsoft.Win32;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class RaceResultImportViewModel : BaseViewModel
	{
		#region Public Properties

		public List<RaceResultImportModel> Models { get; set; }

		public string SelectedFileName { get; set; } = "No File Selected.";

		#endregion

		#region Public Commands

		/// <summary>
		/// Opens the current message thread
		/// </summary>
		public ICommand BrowseFileCommand { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public RaceResultImportViewModel()
		{
			// Create commands
			BrowseFileCommand = new RelayCommand(BrowseFile);
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
			}
		}

		#endregion
	}
}

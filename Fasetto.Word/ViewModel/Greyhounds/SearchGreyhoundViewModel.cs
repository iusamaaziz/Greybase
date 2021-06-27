using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GreyBase.Shared;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class SearchGreyhoundViewModel : BaseViewModel
	{
		#region Public Properties

		public List<string> Greyhounds { get; set; } = Database.Greyhounds.Select(p => p.Name).ToList();

		public string SelectedGreyhound { get; set; }

		public bool ResultsVisible { get; set; } = false;

		public GreyhoundProfileViewModel Greyhound { get; set; }

		#endregion

		#region Commands

		public ICommand SearchGreyhoundCommand { get; set; }

		#endregion

		#region Constructor

		public SearchGreyhoundViewModel()
		{
			SearchGreyhoundCommand = new RelayCommand(ShowResult);
		}

		#endregion

		#region Private Properties

		private void ShowResult()
		{
			Greyhound = new GreyhoundProfileViewModel(Database.Greyhounds.Find(g => g.Name == SelectedGreyhound));

			ResultsVisible = true;
		}

		#endregion
	}
}

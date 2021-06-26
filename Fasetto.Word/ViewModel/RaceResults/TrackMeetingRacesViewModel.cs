using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GreyBase.Shared;
using GreyBase.ViewModel.Base;

namespace GreyBase.ViewModel.RaceResults
{
	public class TrackMeetingRacesViewModel : BaseViewModel
	{
		public Race Race { get; set; }

		#region Public Commands

		/// <summary>
		/// Opens the current message thread
		/// </summary>
		public ICommand OpenGreyhoundProfileCommand { get; set; }

		public ICommand OpenRaceDetailCommand { get; set; }


		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public TrackMeetingRacesViewModel()
		{
			// Create commands
			OpenGreyhoundProfileCommand = new RelayParameterizedCommand(e => OpenGreyhoundProfile(e));
			OpenRaceDetailCommand = new RelayParameterizedCommand(e => OpenRaceResult(e));

		}

		#endregion

		#region Private Members

		private void OpenGreyhoundProfile(object sender)
		{
			Greyhound hound = Database.Greyhounds.Find(h => h.Name == (sender as Greyhound).Name);
			IoC.Application.GoToPage(DataModels.ApplicationPage.Greyhound, new GreyhoundProfileViewModel(hound));
		}

		public void OpenRaceResult(object race)
		{

		}

		#endregion

	}
}

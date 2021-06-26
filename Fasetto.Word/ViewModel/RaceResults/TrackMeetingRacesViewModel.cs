using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GreyBase.Models;
using GreyBase.Shared;
using GreyBase.ViewModel.Base;

namespace GreyBase
{
	public class TrackMeetingRacesViewModel : BaseViewModel
	{
		public static TrackMeetingRacesViewModel Instance => new TrackMeetingRacesViewModel();

		public Race Race { get; set; }

		public List<RaceResultDataModel> Results => new List<RaceResultDataModel>
		{
			new RaceResultDataModel
			{
				 Greyhound = Race.First.Greyhound,
				 Trap = Race.First.Trap,
				 Position = "1st",
				 Distance = Race.Distance,
				 Split = Race.First.Split,
				 Bends = Race.First.Bends,
				 DistanceBeaten = Race.First.DistanceBeaten,
				 Beat = Race.First.Beat,
				 Remarks = Race.First.Remarks,
				 SP = Race.First.SP,
				 BSP = Race.First.BSP,
				 Grade = Race.First.Grade,
				 CalTime = Race.First.CalTime,
				 RaceCode = Race.First.RaceCode,
				 Notes = Race.First.Notes
			},
			new RaceResultDataModel
			{
				 Greyhound = Race.Second.Greyhound,
				 Trap = Race.Second.Trap,
				 Position = "2nd",
				 Distance = Race.Distance,
				 Split = Race.Second.Split,
				 Bends = Race.Second.Bends,
				 DistanceBeaten = Race.Second.DistanceBeaten,
				 Beat = Race.Second.Beat,
				 Remarks = Race.Second.Remarks,
				 SP = Race.Second.SP,
				 BSP = Race.Second.BSP,
				 Grade = Race.Second.Grade,
				 CalTime = Race.Second.CalTime,
				 RaceCode = Race.Second.RaceCode,
				 Notes = Race.Second.Notes
			},
			new RaceResultDataModel
			{
				 Greyhound = Race.Third.Greyhound,
				 Trap = Race.Third.Trap,
				 Position = "3rd",
				 Distance = Race.Distance,
				 Split = Race.Third.Split,
				 Bends = Race.Third.Bends,
				 DistanceBeaten = Race.Third.DistanceBeaten,
				 Beat = Race.Third.Beat,
				 Remarks = Race.Third.Remarks,
				 SP = Race.Third.SP,
				 BSP = Race.Third.BSP,
				 Grade = Race.Third.Grade,
				 CalTime = Race.Third.CalTime,
				 RaceCode = Race.Third.RaceCode,
				 Notes = Race.Third.Notes
			},
			new RaceResultDataModel
			{
				 Greyhound = Race.Forth.Greyhound,
				 Trap = Race.Forth.Trap,
				 Position = "4th",
				 Distance = Race.Distance,
				 Split = Race.Forth.Split,
				 Bends = Race.Forth.Bends,
				 DistanceBeaten = Race.Forth.DistanceBeaten,
				 Beat = Race.Forth.Beat,
				 Remarks = Race.Forth.Remarks,
				 SP = Race.Forth.SP,
				 BSP = Race.Forth.BSP,
				 Grade = Race.Forth.Grade,
				 CalTime = Race.Forth.CalTime,
				 RaceCode = Race.Forth.RaceCode,
				 Notes = Race.Forth.Notes
			},
			new RaceResultDataModel
			{
				 Greyhound = Race.Fifth.Greyhound,
				 Trap = Race.Fifth.Trap,
				 Position = "5th",
				 Distance = Race.Distance,
				 Split = Race.Fifth.Split,
				 Bends = Race.Fifth.Bends,
				 DistanceBeaten = Race.Fifth.DistanceBeaten,
				 Beat = Race.Fifth.Beat,
				 Remarks = Race.Fifth.Remarks,
				 SP = Race.Fifth.SP,
				 BSP = Race.Fifth.BSP,
				 Grade = Race.Fifth.Grade,
				 CalTime = Race.Fifth.CalTime,
				 RaceCode = Race.Fifth.RaceCode,
				 Notes = Race.Fifth.Notes
			},
			new RaceResultDataModel
			{
				 Greyhound = Race.Sixth.Greyhound,
				 Trap = Race.Sixth.Trap,
				 Position = "6th",
				 Distance = Race.Distance,
				 Split = Race.Sixth.Split,
				 Bends = Race.Sixth.Bends,
				 DistanceBeaten = Race.Sixth.DistanceBeaten,
				 Beat = Race.Sixth.Beat,
				 Remarks = Race.Sixth.Remarks,
				 SP = Race.Sixth.SP,
				 BSP = Race.Sixth.BSP,
				 Grade = Race.Sixth.Grade,
				 CalTime = Race.Sixth.CalTime,
				 RaceCode = Race.Sixth.RaceCode,
				 Notes = Race.Sixth.Notes
			}
		};

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
			IoC.Application.GoToPage(DataModels.ApplicationPage.RaceResult, this);
		}

		#endregion

	}
}

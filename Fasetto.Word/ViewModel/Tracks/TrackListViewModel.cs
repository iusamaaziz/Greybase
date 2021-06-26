//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Shared;
using GreyBase.ViewModel.RaceResults;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class TrackListViewModel : TrackViewModel
	{
		#region Public Properties

		//public List<Track> Tracks { get; set; } = Database.Tracks;

		public List<TrackViewModel> Tracks { get; set; }


		#endregion

		#region Constructor

		public TrackListViewModel()
		{
			Tracks = new List<TrackViewModel>();
			foreach (var item in Database.Tracks)
			{
				var trackVm = new TrackViewModel { Name = item.Name, Races = new List<TrackMeetingRacesViewModel>() };
				foreach (var race in item.Races)
				{
					trackVm.Races.Add(new TrackMeetingRacesViewModel { Race = race });
				}
				//Tracks.Add(new TrackViewModel { Name = item.Name, Races = item.Races.ToList() });
				Tracks.Add(trackVm);
			}
		}



		#endregion

		#region Private Properties


		#endregion
	}
}

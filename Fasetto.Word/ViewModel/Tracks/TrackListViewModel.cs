//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Shared;

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
			foreach (Track item in Database.Tracks)
			{
				var trackVm = new TrackViewModel { Name = item.Name, Races = new List<TrackMeetingRacesViewModel>() };
				foreach (var race in item.Races)
				{
					trackVm.Races.Add(new TrackMeetingRacesViewModel(race));
				}
				Tracks.Add(trackVm);
			}
		}


		#endregion

		#region Private Properties


		#endregion
	}
}

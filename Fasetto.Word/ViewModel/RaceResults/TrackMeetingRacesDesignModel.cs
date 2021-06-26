using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Shared;
using GreyBase.ViewModel.RaceResults;

namespace GreyBase
{
	public class TrackMeetingRacesDesignModel : TrackMeetingRacesViewModel
	{

		public static TrackMeetingRacesDesignModel Instance => new TrackMeetingRacesDesignModel();

		public TrackMeetingRacesDesignModel()
		{
			Races = new List<Shared.Race>
			{
				new Shared.Race
				{
					Date = DateTime.Now,
					Grade = "OA",
					Track = new Shared.Track{Name = "Crayford"},
					Distance = "350m", RaceCode = "Cray",
				},
				new Shared.Race
				{
					Date = DateTime.Now,
					Grade = "OA",
					Track = new Shared.Track{Name = "Crayford"},
					Distance = "350m", RaceCode = "Romf",
				}
			};
		}
	}
}

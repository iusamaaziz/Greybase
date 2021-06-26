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
		}
	}
}

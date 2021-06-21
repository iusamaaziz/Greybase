using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.ViewModel.RaceResults
{
	public class TrackMeetingRacesViewModel : BaseViewModel
	{

		public string Track { get; set; }

		public DateTime Date { get; set; }

		public List<MeetingRaceModel> Races { get; set; }

	}
}

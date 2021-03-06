using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GreyBase.Shared;
using GreyBase.ViewModel.Base;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class TrackViewModel : BaseViewModel
	{
		#region Public Properties

		public string Name { get; set; }

		public List<TrackMeetingRacesViewModel> Races { get; set; }

		//public TrackMeetingRacesViewModel Races { get; set; }

		public bool RacesVisible { get; set; }

		#endregion

		#region Constructor

		public TrackViewModel() : base()
		{
			RacesVisibilityCommand = new RelayCommand(SwitchVisibility);
		}

		#endregion

		#region Public Commands

		/// <summary>
		/// The command for when the greyhound button is clicked
		/// </summary>
		public ICommand RacesVisibilityCommand { get; set; }

		#endregion

		#region Private Properties

		public void SwitchVisibility()
		{
			// Toggle menu visibility
			RacesVisible ^= true;
		}



		#endregion
	}
}

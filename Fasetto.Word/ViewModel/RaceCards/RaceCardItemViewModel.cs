using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;

namespace GreyBase
{
	/// <summary>
	/// Contains data for a race card item
	/// </summary>
	public class RaceCardItemViewModel : BaseViewModel
	{
		public string Trap { get; set; }

		public GreyhoundProfileViewModel Greyhound { get; set; }

		public List<RaceCardResultRowViewModel> Races { get; set; }

	}
}

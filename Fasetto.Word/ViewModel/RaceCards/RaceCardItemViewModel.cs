using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;

namespace GreyBase
{
	public class RaceCardItemViewModel : BaseViewModel
	{
		public GreyhoundProfileViewModel Greyhound { get; set; }

		public ObservableCollection<RaceCardResultRowViewModel> Races { get; set; }

	}
}

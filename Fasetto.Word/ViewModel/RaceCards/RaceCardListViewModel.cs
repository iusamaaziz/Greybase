using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	/// <summary>
	/// Contains data for racecard list
	/// </summary>
	public class RaceCardListViewModel : BaseViewModel
	{
		public List<RaceCardItemViewModel> Items { get; set; }

	}
}

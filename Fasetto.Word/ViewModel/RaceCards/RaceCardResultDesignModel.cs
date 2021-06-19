using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	public class RaceCardResultDesignModel : RaceCardResultRowViewModel
	{
		public static ObservableCollection<RaceCardResultDesignModel> Instance => new ObservableCollection<RaceCardResultDesignModel>();

		public RaceCardResultDesignModel()
		{

		}
	}
}

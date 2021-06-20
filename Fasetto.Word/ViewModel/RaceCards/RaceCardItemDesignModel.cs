using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{

	public class RaceCardItemDesignModel : RaceCardItemViewModel
	{
		public static RaceCardItemDesignModel Instance => new RaceCardItemDesignModel();

		public RaceCardItemDesignModel()
		{
			Greyhound = new GreyhoundProfileViewModel() { Name = "Severiano", Trainer = new TrainerViewModel() { Name = "Angela Harrison" } };

			Races = new List<RaceCardResultRowViewModel>
			{
				new RaceCardResultRowViewModel
				{
					Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
					Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray{DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
				},
				new RaceCardResultRowViewModel
				{
					Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
					Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray{DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
				}
			};
		}
	}
}

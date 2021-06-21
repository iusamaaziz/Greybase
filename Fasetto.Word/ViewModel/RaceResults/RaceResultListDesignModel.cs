using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	public class RaceResultListDesignModel : RaceResultListViewModel
	{
		public static RaceResultListDesignModel Instance => new RaceResultListDesignModel();

		public RaceResultListDesignModel()
		{
			Result = new Models.RaceResultModel
			{
				Detail = new Models.RaceDetailsModel { Date = DateTime.Now, Distance = "350m", RaceAmount = "$750", Track = "Crayford" },
				Data = new List<Models.RaceResultDataModel>
				{
					new Models.RaceResultDataModel
					{
						Position = "1st",
						Dog = "Brosna Sally",
						Trap = "Trap1",
						DogDetail = "Les vu d'azur la ces les",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Distance = "2",
						Bend = "2111",
						Trainer = "Marcus K. Smith"
					},
					new Models.RaceResultDataModel
					{
						Position = "2nd",
						Dog = "Mein und",
						Trap = "Trap3",
						DogDetail = "Flash mirth the gild of he feud fellow by harold",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Distance = "1 2/4",
						Bend = "2111",
						Trainer = "Marcus K. Smith"
					},
					new Models.RaceResultDataModel
					{
						Position = "3rd",
						Dog = "Tales of",
						Trap = "Trap6",
						DogDetail = "Les vu d'azur la ces les Esperienza trapassare degli di che",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Distance = "1 1/2",
						Bend = "2111",
						Trainer = "Marcus K. Smith"
					},
					new Models.RaceResultDataModel
					{
						Position = "4th",
						Dog = "Brosna Sally",
						Trap = "Trap2",
						DogDetail = "Les vu d'azur la ces les De anglais pour vacheries les",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Bend = "2111",
						Trainer = "Marcus K. Smith"
					},
					new Models.RaceResultDataModel
					{
						Position = "5th",
						Dog = "Brosna Sally",
						Trap = "Trap5",
						DogDetail = "Les vu d'azur la ces les Dolore est sea dolor",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Bend = "2111",
						Trainer = "Marcus K. Smith"
					},
					new Models.RaceResultDataModel
					{
						Position = "6th",
						Dog = "Brosna Sally",
						Trap = "Trap4",
						DogDetail = "Les vu d'azur la ces les",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Bend = "2111",
						Trainer = "Marcus K. Smith"
					}
				}
			};
		}
	}
}

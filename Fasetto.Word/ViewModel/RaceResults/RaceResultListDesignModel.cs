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
						Dog = new GreyhoundProfileModel
						{
							Name = "Brosna Sally",
							Dob = DateTime.Now,
							Color = "Black",
							RPID = "527890",
							Sire = "Pinpoint Maxi",
							Dam = "Moyar Kite",
							Sex = "Bitch",

							Trainer = new TrainerModel { Name = "J W Gaskin" },

							IdealTrap = 1.0m,
							FirstBendTrap = 2.25m,
							BackStraight = 120,
							Kick = 300,
							RealGrade = "OA",
							Rating = "5"
						},
						Trap = "Trap1",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Distance = "2",
						Bend = "2111"
					},
					new Models.RaceResultDataModel
					{
						Position = "2nd",
						Dog = new GreyhoundProfileModel
						{
							Name = "Brosna Sally",
							Dob = DateTime.Now,
							Color = "Black",
							RPID = "527890",
							Sire = "Pinpoint Maxi",
							Dam = "Moyar Kite",
							Sex = "Bitch",

							Trainer = new TrainerModel { Name = "J W Gaskin" },

							IdealTrap = 1.0m,
							FirstBendTrap = 2.25m,
							BackStraight = 120,
							Kick = 300,
							RealGrade = "OA",
							Rating = "5"
						},
						Trap = "Trap3",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Distance = "1 2/4",
						Bend = "2111"
					},
					new Models.RaceResultDataModel
					{
						Position = "3rd",
						Dog = new GreyhoundProfileModel
						{
							Name = "Brosna Sally",
							Dob = DateTime.Now,
							Color = "Black",
							RPID = "527890",
							Sire = "Pinpoint Maxi",
							Dam = "Moyar Kite",
							Sex = "Bitch",

							Trainer = new TrainerModel { Name = "J W Gaskin" },

							IdealTrap = 1.0m,
							FirstBendTrap = 2.25m,
							BackStraight = 120,
							Kick = 300,
							RealGrade = "OA",
							Rating = "5"
						},
						Trap = "Trap6",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Distance = "1 1/2",
						Bend = "2111"
					},
					new Models.RaceResultDataModel
					{
						Position = "4th",
						Dog = new GreyhoundProfileModel
						{
							Name = "Brosna Sally",
							Dob = DateTime.Now,
							Color = "Black",
							RPID = "527890",
							Sire = "Pinpoint Maxi",
							Dam = "Moyar Kite",
							Sex = "Bitch",

							Trainer = new TrainerModel { Name = "J W Gaskin" },

							IdealTrap = 1.0m,
							FirstBendTrap = 2.25m,
							BackStraight = 120,
							Kick = 300,
							RealGrade = "OA",
							Rating = "5"
						},
						Trap = "Trap2",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Bend = "2111"
					},
					new Models.RaceResultDataModel
					{
						Position = "5th",
						Dog = new GreyhoundProfileModel
						{
							Name = "Brosna Sally",
							Dob = DateTime.Now,
							Color = "Black",
							RPID = "527890",
							Sire = "Pinpoint Maxi",
							Dam = "Moyar Kite",
							Sex = "Bitch",

							Trainer = new TrainerModel { Name = "J W Gaskin" },

							IdealTrap = 1.0m,
							FirstBendTrap = 2.25m,
							BackStraight = 120,
							Kick = 300,
							RealGrade = "OA",
							Rating = "5"
						},
						Trap = "Trap5",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Bend = "2111"
					},
					new Models.RaceResultDataModel
					{
						Position = "6th",
						Dog = new GreyhoundProfileModel
						{
							Name = "Brosna Sally",
							Dob = DateTime.Now,
							Color = "Black",
							RPID = "527890",
							Sire = "Pinpoint Maxi",
							Dam = "Moyar Kite",
							Sex = "Bitch",

							Trainer = new TrainerModel { Name = "J W Gaskin" },

							IdealTrap = 1.0m,
							FirstBendTrap = 2.25m,
							BackStraight = 120,
							Kick = 300,
							RealGrade = "OA",
							Rating = "5"
						},
						Trap = "Trap4",
						SP = "3/5",
						Sec = "3.65",
						Time = "23.54",
						Bend = "2111"
					}
				}
			};
		}
	}
}

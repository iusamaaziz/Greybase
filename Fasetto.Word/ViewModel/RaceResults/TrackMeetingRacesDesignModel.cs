using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.ViewModel.RaceResults;

namespace GreyBase
{
	public class TrackMeetingRacesDesignModel : TrackMeetingRacesViewModel
	{

		public static TrackMeetingRacesDesignModel Instance => new TrackMeetingRacesDesignModel();

		public TrackMeetingRacesDesignModel()
		{
			Track = "Crayford";
			Date = DateTime.Now;
			Races = new List<MeetingRaceModel>
			{
				new MeetingRaceModel
				{
					Distance = "350m", Gd = "OA", Gg = "-30",
					First = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap6"
					},
					Second = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap2"
					},
					Third = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap1"
					},
					Forth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap5"
					},
					Fifth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap3"
					},
					Sixth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap1"
					}

				},
				new MeetingRaceModel
				{
					Distance = "350m", Gd = "OA", Gg = "-30",
					First = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap1"
					},
					Second = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap2"
					},
					Third = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap3"
					},
					Forth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap4"
					},
					Fifth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap5"
					},
					Sixth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap6"
					}

				},
				new MeetingRaceModel
				{
					Distance = "350m", Gd = "OA", Gg = "-30",
					First = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap5"
					},
					Second = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap3"
					},
					Third = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap1"
					},
					Forth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap2"
					},
					Fifth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap4"
					},
					Sixth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap6"
					}

				},
				new MeetingRaceModel
				{
					Distance = "350m", Gd = "OA", Gg = "-30",
					First = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
							Rating = "2"
						},
						Trap = "Trap2"
					},
					Second = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap4"
					},
					Third = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap6"
					},
					Forth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap1"
					},
					Fifth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap3"
					},
					Sixth = new Models.GreyhoundTrapModel
					{
						Greyhound = new GreyhoundProfileModel
						{
							Name = "Ballymac Lydia",
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
						Trap = "Trap5"
					}

				},
			};
		}
	}
}

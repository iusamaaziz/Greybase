using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Shared;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class TrackDesignModel : TrackViewModel
	{
		#region Public Properties

		public static TrackDesignModel Instance => new TrackDesignModel();

		#endregion

		#region Constructor

		public TrackDesignModel()
		{
			Name = "Crayford";
			Races = new List<Shared.Race>
			{
				new Shared.Race
				{
					Date = DateTime.Now,
					Grade = "OA",
					Track = new Shared.Track{Name = "Crayford"},
					Distance = "350m", RaceCode = "Cray",
					Traps = new List<RaceTrap>
					{
						new RaceTrap
						{
							RaceCode = "Cray",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap1"
						},
						new RaceTrap
						{
							RaceCode = "Cray",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap2"
						},
						new RaceTrap
						{
							RaceCode = "Cray",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap3"
						},
						new RaceTrap
						{
							RaceCode = "Cray",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap4"
						}
					}
				},
				new Shared.Race
				{
					Date = DateTime.Now,
					Grade = "OA",
					Track = new Shared.Track{Name = "Crayford"},
					Distance = "350m", RaceCode = "Romf",
					Traps = new List<RaceTrap>
					{
						new RaceTrap
						{
							RaceCode = "Romf",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap1"
						},
						new RaceTrap
						{
							RaceCode = "Romf",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap2"
						},
						new RaceTrap
						{
							RaceCode = "Romf",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap3"
						},
						new RaceTrap
						{
							RaceCode = "Romf",
							Greyhound = new Greyhound
							{
								Name = "Ballymac Lydia",
								Dob = DateTime.Now,
								Color = "Black",
								RPID = "527890",
								Sire = "Pinpoint Maxi",
								Dam = "Moyar Kite",
								Sex = "Bitch",

								Trainer = new Trainer { Name = "J W Gaskin" },

								IdealTrap = 1.0m,
								FirstBendTrap = 2.25m,
								BackStraight = 120,
								Kick = 300,
								RealGrade = "OA",
								Rating = "5"
							},
							Trap = "Trap4"
						}
					}
				}
			};
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

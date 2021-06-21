using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	/// <summary>
	/// Data model for race card list
	/// </summary>
	public class RaceCardListDesignModel : RaceCardListViewModel
	{
		public static RaceCardListDesignModel Instance => new RaceCardListDesignModel();

		public RaceCardListDesignModel()
		{
			Items = new List<RaceCardItemViewModel>
			{
				new RaceCardItemDesignModel
				{
					Trap = "Trap1",
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
					Races = new List<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210", DistanceBeaten = "50m", Beat = "Kicifrázva", Pos = "2nd"
					},
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"
					},
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"
					}}
				},
				new RaceCardItemDesignModel
				{
					Trap = "Trap2",
					Greyhound = new GreyhoundProfileModel
					{
						Name = "Bramble Tobby",
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
					Races = new List<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"},
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"}}
				},
				new RaceCardItemDesignModel
				{
					Trap = "Trap3",
					Greyhound = new GreyhoundProfileModel() { Name = "Lunaria", Trainer = new TrainerModel() { Name = "Raymond  Hale" } },
					Races = new List<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"},
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"},
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"}}
				},
				new RaceCardItemDesignModel
				{
					Trap = "Trap4",
					Greyhound = new GreyhoundProfileModel() { Name = "Lunaria", Trainer = new TrainerModel() { Name = "Raymond  Hale" } },
					Races = new List<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"}}
				},
				new RaceCardItemDesignModel
				{
					Trap = "Trap5",
					Greyhound = new GreyhoundProfileModel() { Name = "Lunaria", Trainer = new TrainerModel() { Name = "Raymond  Hale" } },
					Races = new List<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"},
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"}}
				},
				new RaceCardItemDesignModel
				{
					Trap = "Trap6",
					Greyhound = new GreyhoundProfileModel() { Name = "Lunaria", Trainer = new TrainerModel() { Name = "Raymond  Hale" } },
					Races = new List<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"},
					new RaceCardResultRowViewModel
					{Date = DateTime.Now, Distance = "450", Bends = "Nitro June", Remarks = "Sample remarks", Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split = "210", DistanceBeaten = "100m", Beat = "Sadipscing", Pos = "1st"}}
				}
			};
		}
	}
}

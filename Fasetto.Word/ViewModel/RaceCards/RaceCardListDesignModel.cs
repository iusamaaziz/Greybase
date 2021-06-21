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
					Greyhound = new GreyhoundProfileModel() { Name = "Severiano", Trainer = new TrainerModel() { Name = "Angela Harrison" } },
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
					Greyhound = new GreyhoundProfileModel() { Name = "Bramble Tobby", Trainer = new TrainerModel() { Name = "Steven Anderson" } },
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	public class RaceCardResultListDesignModel : RaceCardResultListViewModel
	{
		public ObservableCollection<RaceCardResultListDesignModel> Instance => new ObservableCollection<RaceCardResultListDesignModel>();

		public RaceCardResultListDesignModel()
		{
			Items = new List<RaceCardItemDesignModel>
			{
				new RaceCardItemDesignModel
				{
					Greyhound = new GreyhoundProfileViewModel() { Name = "Severiano", Trainer = new TrainerViewModel() { Name = "Angela Harrison" } },
					Races = new ObservableCollection<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
					},
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
					}}
				},
				new RaceCardItemDesignModel
				{
					Greyhound = new GreyhoundProfileViewModel() { Name = "Bramble Tobby", Trainer = new TrainerViewModel() { Name = "Steven Anderson" } },
					Races = new ObservableCollection<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
					},
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
					}}
				},
				new RaceCardItemDesignModel
				{
					Greyhound = new GreyhoundProfileViewModel() { Name = "Lunaria", Trainer = new TrainerViewModel() { Name = "Raymond  Hale" } },
					Races = new ObservableCollection<RaceCardResultRowViewModel>{
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
					},
					new RaceCardResultRowViewModel
					{
						Date = DateTime.Now, Distance = "450", Win2nd = "Nitro June", Remarks = "Sample remarks",
						Grade = "OA", BSP = "7/2", CalTime = "CalTime", Racecode = $"{DateTime.Now.ToShortDateString()}Cray {DateTime.Now.ToShortTimeString()}", Trap = "2", SP = "10/F", Split ="210"
					}}
				}
			};
		}
	}
}

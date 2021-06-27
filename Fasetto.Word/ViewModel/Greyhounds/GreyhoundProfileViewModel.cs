using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Models;
using GreyBase.Shared;

namespace GreyBase
{
	public class GreyhoundProfileViewModel : BaseViewModel
	{
		public static GreyhoundProfileViewModel Instance => new GreyhoundProfileViewModel();

		public Greyhound Greyhound { get; set; }

		public List<RaceResultDataModel> Results
		{
			get
			{
				List<RaceResultDataModel> li = new List<RaceResultDataModel>();
				foreach (var Race in Greyhound.Races)
				{
					if (Race.First.Greyhound.Name == Greyhound.Name)
					{
						var item = new RaceResultDataModel
						{
							Race = Race,
							Greyhound = Greyhound,
							Trap = Race.First.Trap,
							Position = "1st",
							Distance = Race.Distance,
							Split = Race.First.Split,
							Bends = Race.First.Bends,
							DistanceBeaten = Race.First.DistanceBeaten,
							Beat = Race.First.Beat,
							Remarks = Race.First.Remarks,
							SP = Race.First.SP,
							BSP = Race.First.BSP,
							Grade = Race.First.Grade,
							CalTime = Race.First.CalTime,
							RaceCode = Race.First.RaceCode,
							Notes = Race.First.Notes
						};
						li.Add(item);
					}
					else if (Race.Forth.Greyhound.Name == Greyhound.Name)
					{
						var item = new RaceResultDataModel
						{
							Greyhound = Greyhound,
							Trap = Race.Forth.Trap,
							Position = "1st",
							Distance = Race.Distance,
							Split = Race.Forth.Split,
							Bends = Race.Forth.Bends,
							DistanceBeaten = Race.Forth.DistanceBeaten,
							Beat = Race.Forth.Beat,
							Remarks = Race.Forth.Remarks,
							SP = Race.Forth.SP,
							BSP = Race.Forth.BSP,
							Grade = Race.Forth.Grade,
							CalTime = Race.Forth.CalTime,
							RaceCode = Race.Forth.RaceCode,
							Notes = Race.Forth.Notes
						};
						li.Add(item);
					}
					else if (Race.Third.Greyhound.Name == Greyhound.Name)
					{
						var item = new RaceResultDataModel
						{
							Greyhound = Greyhound,
							Trap = Race.Third.Trap,
							Position = "1st",
							Distance = Race.Distance,
							Split = Race.Third.Split,
							Bends = Race.Third.Bends,
							DistanceBeaten = Race.Third.DistanceBeaten,
							Beat = Race.Third.Beat,
							Remarks = Race.Third.Remarks,
							SP = Race.Third.SP,
							BSP = Race.Third.BSP,
							Grade = Race.Third.Grade,
							CalTime = Race.Third.CalTime,
							RaceCode = Race.Third.RaceCode,
							Notes = Race.Third.Notes
						};
						li.Add(item);
					}
					else if (Race.Forth.Greyhound.Name == Greyhound.Name)
					{
						var item = new RaceResultDataModel
						{
							Greyhound = Greyhound,
							Trap = Race.Forth.Trap,
							Position = "1st",
							Distance = Race.Distance,
							Split = Race.Forth.Split,
							Bends = Race.Forth.Bends,
							DistanceBeaten = Race.Forth.DistanceBeaten,
							Beat = Race.Forth.Beat,
							Remarks = Race.Forth.Remarks,
							SP = Race.Forth.SP,
							BSP = Race.Forth.BSP,
							Grade = Race.Forth.Grade,
							CalTime = Race.Forth.CalTime,
							RaceCode = Race.Forth.RaceCode,
							Notes = Race.Forth.Notes
						};
						li.Add(item);
					}
					else if (Race.Fifth.Greyhound.Name == Greyhound.Name)
					{
						var item = new RaceResultDataModel
						{
							Greyhound = Greyhound,
							Trap = Race.Fifth.Trap,
							Position = "1st",
							Distance = Race.Distance,
							Split = Race.Fifth.Split,
							Bends = Race.Fifth.Bends,
							DistanceBeaten = Race.Fifth.DistanceBeaten,
							Beat = Race.Fifth.Beat,
							Remarks = Race.Fifth.Remarks,
							SP = Race.Fifth.SP,
							BSP = Race.Fifth.BSP,
							Grade = Race.Fifth.Grade,
							CalTime = Race.Fifth.CalTime,
							RaceCode = Race.Fifth.RaceCode,
							Notes = Race.Fifth.Notes
						};
						li.Add(item);
					}
					else if (Race.Sixth.Greyhound.Name == Greyhound.Name)
					{
						var item = new RaceResultDataModel
						{
							Greyhound = Greyhound,
							Trap = Race.Sixth.Trap,
							Position = "1st",
							Distance = Race.Distance,
							Split = Race.Sixth.Split,
							Bends = Race.Sixth.Bends,
							DistanceBeaten = Race.Sixth.DistanceBeaten,
							Beat = Race.Sixth.Beat,
							Remarks = Race.Sixth.Remarks,
							SP = Race.Sixth.SP,
							BSP = Race.Sixth.BSP,
							Grade = Race.Sixth.Grade,
							CalTime = Race.Sixth.CalTime,
							RaceCode = Race.Sixth.RaceCode,
							Notes = Race.Sixth.Notes
						};
						li.Add(item);
					}
				}
				return li;
			}
			set { }
		}

		public GreyhoundProfileViewModel() : base()
		{

		}

		public GreyhoundProfileViewModel(Greyhound hound) : base()
		{
			// Todo -- Remove connection and add reference.
			Greyhound = Database.Greyhounds.Find(h => h.Name == hound.Name);
		}

	}
}

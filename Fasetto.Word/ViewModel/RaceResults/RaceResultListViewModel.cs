using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GreyBase.Models;
using GreyBase.Shared;

namespace GreyBase
{
	public class RaceResultListViewModel : BaseViewModel
	{
		public static RaceResultListViewModel Instance => new RaceResultListViewModel();

		#region Public Properties

		public List<RaceResultDataModel> Results => new List<RaceResultDataModel>
		{
			new RaceResultDataModel
			{
				 Greyhound = Race.First.Greyhound,
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
			}
		};

		public Race Race { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public RaceResultListViewModel()
		{

		}

		#endregion

		#region Command Methods


		#endregion

	}
}

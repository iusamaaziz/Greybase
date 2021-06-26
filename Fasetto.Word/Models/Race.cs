using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Shared
{
	/// <summary>
	/// A Db class for Race
	/// </summary>
	public class Race
	{
		#region Public Properties

		public string RaceCode { get; set; }

		public DateTime Date { get; set; }

		public string Grade { get; set; }

		public string Distance { get; set; }

		public Track Track { get; set; }

		public RaceTrap First { get; set; }
		public RaceTrap Second { get; set; }
		public RaceTrap Third { get; set; }
		public RaceTrap Forth { get; set; }
		public RaceTrap Fifth { get; set; }
		public RaceTrap Sixth { get; set; }

		#endregion

		#region Constructor

		public Race()
		{
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

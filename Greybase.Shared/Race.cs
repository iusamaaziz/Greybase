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

		public ICollection<RaceTrap> Traps { get; set; }

		#endregion

		#region Constructor

		public Race()
		{
			Traps = new HashSet<RaceTrap>();
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

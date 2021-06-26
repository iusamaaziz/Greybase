using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Shared
{
	/// <summary>
	/// To store which greyhound ran in which trap of a race
	/// </summary>
	public class RaceTrap
	{
		#region Public Properties

		public string RaceCode { get; set; }

		public Greyhound Greyhound { get; set; }

		public string Trap { get; set; }

		public string Distance { get; set; }

		public string Split { get; set; }

		public string Bends { get; set; }

		public string DistanceBeaten { get; set; }

		public string Beat { get; set; }

		public string Remarks { get; set; }

		public string SP { get; set; }

		public string BSP { get; set; }

		public string Grade { get; set; }

		public string CalTime { get; set; }

		public string Notes { get; set; }

		#endregion

		#region Constructor

		public RaceTrap()
		{
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

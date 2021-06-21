using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Models;

namespace GreyBase
{
	public class MeetingRaceModel
	{
		public DateTime Time { get; set; }

		public string Distance { get; set; }

		public string Gd { get; set; }

		public string Gg { get; set; }

		public string RaceCode { get; set; }

		/// <summary>
		/// Donated combined model for <see cref="GreyhoundProfileModel"/> and Trap
		/// </summary>
		public GreyhoundTrapModel First { get; set; }

		public GreyhoundTrapModel Second { get; set; }
		public GreyhoundTrapModel Third { get; set; }
		public GreyhoundTrapModel Forth { get; set; }
		public GreyhoundTrapModel Fifth { get; set; }
		public GreyhoundTrapModel Sixth { get; set; }
	}
}

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

		public Race Race { get; set; }

		public Greyhound Greyhound { get; set; }

		public string Trap { get; set; }

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

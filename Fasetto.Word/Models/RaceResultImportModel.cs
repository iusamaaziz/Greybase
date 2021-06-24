using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class RaceResultImportModel
	{
		#region Public Properties

		/// <summary>
		/// Contains only date in format 01-Jan
		/// </summary>
		public DateTime Date { get; set; }

		public string Track { get; set; }

		/// <summary>
		/// Includes race time, grade and distance in format HH:MM Grade Distance
		/// </summary>
		public string RaceTime { get; set; }


		public string FirstDog { get; set; }

		public string FirstBsp { get; set; }

		public string FirstIsp { get; set; }


		public string SecondDog { get; set; }

		public string SecondBsp { get; set; }

		public string SecondIsp { get; set; }


		public string ThirdDog { get; set; }

		public string ThirdBsp { get; set; }

		public string ThirdIsp { get; set; }


		public string ForthDog { get; set; }

		public string ForthBsp { get; set; }

		public string ForthIsp { get; set; }


		public string FifthDog { get; set; }

		public string FifthBsp { get; set; }

		public string FifthIsp { get; set; }


		public string SixthDog { get; set; }

		public string SixthBsp { get; set; }

		public string SixthIsp { get; set; }

		#endregion
	}
}

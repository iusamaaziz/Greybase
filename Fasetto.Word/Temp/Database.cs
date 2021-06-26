using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Shared;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class Database
	{
		#region Public Properties

		public static List<Greyhound> Greyhounds { get; set; } = new List<Greyhound>();

		public static List<Trainer> Trainers { get; set; } = new List<Trainer>();

		public static List<Track> Tracks { get; set; } = new List<Track>();

		public static List<RaceTrap> RaceTraps { get; set; } = new List<RaceTrap>();

		public static List<Race> Races { get; set; } = new List<Race>();

		#endregion

	}
}

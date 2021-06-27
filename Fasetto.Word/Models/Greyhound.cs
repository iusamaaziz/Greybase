using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace GreyBase.Shared
{
	/// <summary>
	/// Contains Greyhound complete profile information
	/// </summary>
	public class Greyhound
	{
		#region Public Properties

		public int Id { get; set; }

		public string RPID { get; set; }

		public string Name { get; set; }

		public DateTime Dob { get; set; }

		public string Sire { get; set; }

		public string Dam { get; set; }

		public string Color { get; set; }

		public string Sex { get; set; }

		public Trainer Trainer { get; set; }

		public decimal IdealTrap { get; set; }

		public decimal FirstBendTrap { get; set; }

		public decimal BackStraight { get; set; }

		public string RealGrade { get; set; }

		public decimal Kick { get; set; }

		public string Rating { get; set; }

		public string AvgSplit { get; set; }

		public string PaceToBend { get; set; }

		/// <summary>
		/// Can be $, $$, $$$
		/// </summary>
		public string Characters { get; set; }

		public ICollection<RaceTrap> RaceTraps => Database.RaceTraps.Where(hell => hell.Greyhound.Id == Id).ToList();

		public List<Race> Races
		{
			get
			{
				var traps = Database.RaceTraps.Where(trap => trap.Greyhound.Name == Name).Distinct();
				var racesCodes = traps.Select(t => t.RaceCode).Distinct();
				var races = new List<Race>();
				foreach (var code in racesCodes)
				{
					var matching = Database.Races.Where(race => race.RaceCode == code).FirstOrDefault();
					if (!races.Exists(r => r.RaceCode == code))
					{
						races.Add(matching);
					}
				}
				return races.Take(6).OrderByDescending(p => p.Date).ToList();
			}
			set { }
		}

		#endregion

		#region Constructor

		public Greyhound()
		{
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Models;
using GreyBase.Shared;

namespace GreyBase.ValueConvertors
{
	/// <summary>
	/// 
	/// </summary>
	public class ImportHelper
	{
		#region Public Properties

		public static void ConvertImport(List<RaceResultImportModel> models)
		{
			foreach (var item in models)
			{

				Track track = new Track { Name = item.Track };

				if (!Database.Tracks.Exists(t => t.Name == item.Track))
				{
					track = new Track { Name = item.Track };
				}
				else
				{
					track = Database.Tracks.Find(t => t.Name == item.Track);
				}

				Greyhound g1 = new Greyhound { Name = item.FirstDog };
				Greyhound g2 = new Greyhound { Name = item.SecondDog };
				Greyhound g3 = new Greyhound { Name = item.ThirdDog };
				Greyhound g4 = new Greyhound { Name = item.ForthDog };
				Greyhound g5 = new Greyhound { Name = item.FifthDog };
				Greyhound g6 = new Greyhound { Name = item.SixthDog };

				ImportHelper h = new ImportHelper();
				h.AddGreyhoundToDb(g1);
				h.AddGreyhoundToDb(g2);
				h.AddGreyhoundToDb(g3);
				h.AddGreyhoundToDb(g4);
				h.AddGreyhoundToDb(g5);
				h.AddGreyhoundToDb(g6);

				string raceCode = $"{track.Name.Substring(0, 4)}-{item.Date.ToString("dd")}{item.Date.ToString("MM")}{item.Date.ToString("yyyy")}-{item.Date.ToString("HH:mm")}";

				Race race = new Race
				{
					RaceCode = raceCode,
					Date = item.Date,
					Distance = item.Distance,
					Grade = item.Grade,
					Track = track,
					First = new RaceTrap { RaceCode = raceCode, Greyhound = g1, Trap = item.FirstPos, BSP = item.FirstBsp, Grade = item.Grade, SP = item.FirstBsp },
					Second = new RaceTrap { RaceCode = raceCode, Greyhound = g2, Trap = item.SecondPos, BSP = item.SecondBsp, Grade = item.Grade, SP = item.SecondIsp },
					Third = new RaceTrap { RaceCode = raceCode, Greyhound = g3, Trap = item.ThirdPos, BSP = item.ThirdBsp, Grade = item.Grade, SP = item.ThirdIsp },
					Forth = new RaceTrap { RaceCode = raceCode, Greyhound = g4, Trap = item.ForthPos, BSP = item.ForthBsp, Grade = item.Grade, SP = item.ForthIsp },
					Fifth = new RaceTrap { RaceCode = raceCode, Greyhound = g5, Trap = item.FifthPos, BSP = item.FifthBsp, Grade = item.Grade, SP = item.FifthIsp },
					Sixth = new RaceTrap { RaceCode = raceCode, Greyhound = g6, Trap = item.SixthPos, BSP = item.SixthIsp, Grade = item.Grade, SP = item.SixthIsp }
				};

				if (!Database.Races.Exists(r => r.RaceCode == race.RaceCode))
				{
					Database.Races.Add(race);
					Database.RaceTraps.Add(race.First);
					Database.RaceTraps.Add(race.Second);
					Database.RaceTraps.Add(race.Third);
					Database.RaceTraps.Add(race.Forth);
					Database.RaceTraps.Add(race.First);
					Database.RaceTraps.Add(race.Sixth);
				}

				track.Races.Add(race);
				if (!Database.Tracks.Exists(t => t.Name == track.Name))
					Database.Tracks.Add(track);
			}
		}

		#endregion

		#region Private Properties

		private void AddGreyhoundToDb(Greyhound hound)
		{
			if (Database.Greyhounds.Exists(h => h.Name == hound.Name))
				return;
			Database.Greyhounds.Add(hound);
		}

		#endregion
	}
}

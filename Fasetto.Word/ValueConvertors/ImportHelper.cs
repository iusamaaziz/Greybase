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

				string raceCode = $"{track.Name}{item.Date}";

				Race race = new Race
				{
					RaceCode = raceCode,
					Date = item.Date,
					Distance = item.Distance,
					Grade = item.Grade,
					Track = track,
					First = new RaceTrap { RaceCode = raceCode, Greyhound = g1, Trap = item.FirstPos },
					Second = new RaceTrap { RaceCode = raceCode, Greyhound = g2, Trap = item.SecondPos },
					Third = new RaceTrap { RaceCode = raceCode, Greyhound = g3, Trap = item.ThirdPos },
					Forth = new RaceTrap { RaceCode = raceCode, Greyhound = g4, Trap = item.ForthPos },
					Fifth = new RaceTrap { RaceCode = raceCode, Greyhound = g5, Trap = item.FifthPos },
					Sixth = new RaceTrap { RaceCode = raceCode, Greyhound = g6, Trap = item.SixthPos }
				};

				if (!Database.Races.Exists(r => r.RaceCode == race.RaceCode))
					Database.Races.Add(race);

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

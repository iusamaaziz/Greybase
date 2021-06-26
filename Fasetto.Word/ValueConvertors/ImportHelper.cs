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

				Database.Greyhounds.Add(g1);
				Database.Greyhounds.Add(g2);
				Database.Greyhounds.Add(g3);
				Database.Greyhounds.Add(g4);
				Database.Greyhounds.Add(g5);
				Database.Greyhounds.Add(g6);

				string raceCode = $"{track.Name}{item.Date}";

				Race race = new Race
				{
					RaceCode = raceCode,
					Date = item.Date,
					Distance = item.Distance,
					Grade = item.Grade,
					Track = track,
					Traps = new List<RaceTrap>
					{
						new RaceTrap { RaceCode = raceCode, Greyhound = g1, Trap = item.FirstPos },
						new RaceTrap { RaceCode = raceCode, Greyhound = g2, Trap = item.SecondPos },
						new RaceTrap { RaceCode = raceCode, Greyhound = g3, Trap = item.ThirdPos },
						new RaceTrap { RaceCode = raceCode, Greyhound = g4, Trap = item.ForthDog },
						new RaceTrap { RaceCode = raceCode, Greyhound = g5, Trap = item.FifthDog },
						new RaceTrap { RaceCode = raceCode, Greyhound = g6, Trap = item.SixthDog }
					}
				};

				Database.RaceTraps.AddRange(race.Traps);
				if (!Database.Races.Exists(r => r.RaceCode == race.RaceCode))
					Database.Races.Add(race);

				track.Races.Add(race);
				if (!Database.Tracks.Exists(t => t.Name == track.Name))
					Database.Tracks.Add(track);
			}
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

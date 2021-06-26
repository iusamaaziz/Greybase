using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	/// <summary>
	/// 
	/// </summary>
	public class TrackListDesignModel : TrackListViewModel
	{
		#region Public Properties

		public static TrackListDesignModel Instance => new TrackListDesignModel();

		#endregion

		#region Constructor

		public TrackListDesignModel()
		{
			Tracks = new List<Shared.Track>
			{
				new Shared.Track{Name = "Crayford"},
				new Shared.Track{Name = "Romford"},
				new Shared.Track{Name = "Central Park"},
				new Shared.Track{Name = "Doncaster"},
				new Shared.Track{Name = "Harlow"}
			};
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

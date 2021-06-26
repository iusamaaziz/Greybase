using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Shared
{
	/// <summary>
	/// A race Track
	/// </summary>
	public class Track
	{
		#region Public Properties

		public string Name { get; set; }

		public ICollection<Race> Races { get; set; }

		#endregion

		#region Constructor

		public Track()
		{
			Races = new HashSet<Race>();
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

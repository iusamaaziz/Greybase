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
	public class TrackListViewModel : BaseViewModel
	{
		#region Public Properties

		public List<Track> Tracks { get; set; } = Database.Tracks;

		#endregion

		#region Constructor

		public TrackListViewModel()
		{
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

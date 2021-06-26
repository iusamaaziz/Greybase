using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GreyBase.Models;
using GreyBase.Shared;

namespace GreyBase
{
	public class RaceResultListViewModel : BaseViewModel
	{

		#region Public Properties

		public RaceResultModel Result { get; set; }

		public Race Race { get; set; }

		#endregion

		#region Public Commands


		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public RaceResultListViewModel()
		{
			// Create commands
		}

		#endregion

		#region Command Methods


		#endregion

	}
}

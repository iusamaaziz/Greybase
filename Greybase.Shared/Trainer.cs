using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Shared
{
	/// <summary>
	/// A trainer for each greyhound
	/// </summary>
	public class Trainer
	{
		#region Public Properties

		public string Name { get; set; }

		/// <summary>
		/// Greyhounds being trained by this
		/// </summary>
		public ICollection<Greyhound> Greyhounds { get; set; }

		#endregion

		#region Constructor

		public Trainer()
		{
			Greyhounds = new HashSet<Greyhound>();
		}

		#endregion

		#region Private Properties


		#endregion
	}
}

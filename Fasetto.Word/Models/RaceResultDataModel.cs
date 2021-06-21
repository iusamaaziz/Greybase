using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Models
{
	public class RaceResultDataModel
	{
		public string Position { get; set; }

		public GreyhoundProfileModel Dog { get; set; }

		public string Trap { get; set; }

		public string SP { get; set; }

		public string Sec { get; set; }

		public string Time { get; set; }

		public string Distance { get; set; }

		public string Bend { get; set; }

	}
}

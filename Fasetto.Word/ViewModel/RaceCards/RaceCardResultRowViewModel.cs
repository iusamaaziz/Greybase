using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	/// <summary>
	/// Contains datagrid values for each RaceCard Item
	/// </summary>
	public class RaceCardResultRowViewModel : BaseViewModel
	{
		public DateTime Date { get; set; }

		public string Distance { get; set; }

		public string Trap { get; set; }

		public string Split { get; set; }

		public string Win2nd { get; set; }

		public string Remarks { get; set; }

		public string SP { get; set; }

		public string BSP { get; set; }

		public string Grade { get; set; }

		public string CalTime { get; set; }

		public string Racecode { get; set; }

		public string Notes { get; set; }

	}
}

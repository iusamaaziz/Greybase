using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Models
{
	public class RaceDetailsModel
	{
		public int Id { get; set; }

		public string Track { get; set; }

		public DateTime Date { get; set; }

		public string RaceAmount { get; set; }

		public string Distance { get; set; }

	}
}

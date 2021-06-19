using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	public class GreyhoundProfileViewModel : BaseViewModel
	{
		public string RPID { get; set; }

		public string Name { get; set; }

		public string Sire { get; set; }

		public string Dam { get; set; }

		public string Color { get; set; }

		public string Sex { get; set; }

		public TrainerViewModel Trainer { get; set; }

		public decimal IdealTrap { get; set; }

		public decimal FirstBendTrap { get; set; }

		public decimal BackStraight { get; set; }

		public string RealGrade { get; set; }

		public string Kick { get; set; }

		public string Rating { get; set; }

	}
}

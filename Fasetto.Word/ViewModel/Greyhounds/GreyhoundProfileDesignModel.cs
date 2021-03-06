using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Shared;

namespace GreyBase
{
	public class GreyhoundProfileDesignModel : GreyhoundProfileViewModel
	{

		public static GreyhoundProfileDesignModel Instance => new GreyhoundProfileDesignModel();
		public GreyhoundProfileDesignModel()
		{
			Greyhound = new Greyhound
			{
				Name = "Ballymac Lydia",
				Dob = DateTime.Now,
				Color = "Black",
				RPID = "527890",
				Sire = "Pinpoint Maxi",
				Dam = "Moyar Kite",
				Sex = "Bitch",

				Trainer = new Trainer { Name = "J W Gaskin" },

				IdealTrap = 1.0m,
				FirstBendTrap = 2.25m,
				BackStraight = 120,
				Kick = 300,
				RealGrade = "OA",
				Rating = "5"
			};
		}
	}
}

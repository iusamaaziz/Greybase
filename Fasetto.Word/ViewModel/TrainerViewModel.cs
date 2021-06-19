using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	public class TrainerViewModel : BaseViewModel
	{
		public string Name { get; set; }

		public List<GreyhoundProfileViewModel> Greyhounds { get; set; }

	}
}

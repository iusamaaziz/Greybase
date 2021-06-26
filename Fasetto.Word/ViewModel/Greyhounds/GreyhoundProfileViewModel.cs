using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.Shared;

namespace GreyBase
{
	public class GreyhoundProfileViewModel : BaseViewModel
	{
		public Greyhound Greyhound { get; set; }

		public GreyhoundProfileViewModel() : base()
		{

		}

		public GreyhoundProfileViewModel(Greyhound hound) : base()
		{
			Greyhound = hound;
		}

	}
}

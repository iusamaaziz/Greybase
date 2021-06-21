using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.Models
{
	public class RaceResultModel
	{
		public RaceDetailsModel Detail { get; set; }

		public List<RaceResultDataModel> Data { get; set; }

	}
}

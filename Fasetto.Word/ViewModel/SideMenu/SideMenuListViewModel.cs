using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using GreyBase.DataModels;
using GreyBase.ViewModel.Base;

namespace GreyBase
{
	public class SideMenuListViewModel : BaseViewModel
	{
		public static List<SideMenuItemViewModel> Items { get; set; }
	}
}

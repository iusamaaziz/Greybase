using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.IoC.Interfaces;
using GreyBase.ViewModel.Dialogs;

namespace GreyBase.IoC
{
	public class UIManager : IUIManager
	{
		public Task ShowMessage(MessageBoxDialogViewModel viewModel)
		{
			throw new NotImplementedException();
		}
	}
}

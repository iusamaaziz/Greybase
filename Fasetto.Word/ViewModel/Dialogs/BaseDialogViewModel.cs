﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase.ViewModel.Dialogs
{
	/// <summary>
	/// A base view model for any dialogs
	/// </summary>
	public class BaseDialogViewModel : BaseViewModel
	{
		/// <summary>
		/// The title of the dialog
		/// </summary>
		public string Title { get; set; }
	}
}

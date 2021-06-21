﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.ViewModel.Dialogs;

namespace GreyBase
{
	/// <summary>
	/// Details for a message box dialog
	/// </summary>
	public class MessageBoxDialogDesignModel : MessageBoxDialogViewModel
	{
		#region Singleton

		/// <summary>
		/// A single instance of the design model
		/// </summary>
		public static MessageBoxDialogDesignModel Instance => new MessageBoxDialogDesignModel();

		#endregion

		#region Constructor

		/// <summary>
		/// Default Constructor
		/// </summary>
		public MessageBoxDialogDesignModel()
		{
			OkText = "OK";
			Message = "Design time messages are fun :)";
		}

		#endregion
	}
}

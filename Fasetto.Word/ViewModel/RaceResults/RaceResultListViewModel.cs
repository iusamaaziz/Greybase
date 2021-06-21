using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using GreyBase.Models;

namespace GreyBase
{
	public class RaceResultListViewModel : BaseViewModel
	{
		public RaceResultModel Result { get; set; }

		#region Public Properties

		/// <summary>
		/// True to show the attachment menu, false to hide it
		/// </summary>
		public bool AttachmentMenuVisible { get; set; }

		/// <summary>
		/// The view model for the Greyhound profile
		/// </summary>
		public GreyhoundProfilePopupMenuViewModel AttachmentMenu { get; set; }

		#endregion

		#region Public Commands

		/// <summary>
		/// The command for when the greyhound button is clicked
		/// </summary>
		public ICommand AttachmentButtonCommand { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public RaceResultListViewModel()
		{
			// Create commands
			AttachmentButtonCommand = new RelayCommand(AttachmentButton);

			// Make a default menu
			AttachmentMenu = new GreyhoundProfilePopupMenuViewModel();
		}

		#endregion

		#region Command Methods

		/// <summary>
		/// When the attachment button is clicked show/hide the attachment popup
		/// </summary>
		public void AttachmentButton()
		{
			// Toggle menu visibility
			AttachmentMenuVisible ^= true;
		}

		#endregion

	}
}

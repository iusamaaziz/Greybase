using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;

namespace GreyBase
{
	/// <summary>
	/// Contains data for a race card item
	/// </summary>
	public class RaceCardItemViewModel : BaseViewModel
	{
		public string Trap { get; set; }

		public GreyhoundProfileModel Greyhound { get; set; }

		public List<RaceCardResultRowViewModel> Races { get; set; }

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
		public RaceCardItemViewModel()
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

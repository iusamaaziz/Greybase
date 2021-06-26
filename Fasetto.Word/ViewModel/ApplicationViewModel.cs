using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using GreyBase.DataModels;

namespace GreyBase.ViewModel
{
	/// <summary>
	/// The application state as a view model
	/// </summary>
	public class ApplicationViewModel : BaseViewModel
	{
		/// <summary>
		/// The current page of the application
		/// </summary>
		public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Dashboard;

		/// <summary>
		/// True if the side menu should be shown
		/// </summary>
		public bool SideMenuVisible { get; set; } = false;

		/// <summary>
		/// The view model to use for the current page when the CurrentPage changes
		/// NOTE: This is not a live up-to-date view model of the current page
		///       it is simply used to set the view model of the current page 
		///       at the time it changes
		/// </summary>
		public BaseViewModel CurrentPageViewModel { get; set; }

		/// <summary>
		/// Navigates to the specified page
		/// </summary>
		/// <param name="page">The page to go to</param>
		public void GoToPage(ApplicationPage page, BaseViewModel viewModel = null)
		{
			// Always hide settings page if we are changing pages
			// SettingsMenuVisible = false;

			// Set the view model
			CurrentPageViewModel = viewModel;
			SideMenuListViewModel.Items.ForEach(a => a.IsActive = false);
			((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = page;

			if (viewModel != null)
			{
				((MainWindow)Application.Current.MainWindow).MainFrame.Content = new ApplicationPageValueConvertor().Convert(page, null, viewModel, null);
			}
			// Set the current page
			//CurrentPage = page;

			// Fire off a CurrentPage changed event
			OnPropertyChanged(nameof(CurrentPage));

			// Show side menu or not?
			//SideMenuVisible = page == ApplicationPage.Chat;
			SideMenuVisible = true;
		}
	}
}

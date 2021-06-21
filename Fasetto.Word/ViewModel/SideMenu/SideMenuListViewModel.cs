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
		public List<SideMenuItemViewModel> Items { get; set; }

		#region Commands

		/// <summary>
		/// The command to login
		/// </summary>
		public ICommand ShowRaceCardCommand { get; set; }

		/// <summary>
		/// The command to register for a new account
		/// </summary>
		public ICommand ShowRaceResultCommand { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public SideMenuListViewModel()
		{
			// Create commands
			ShowRaceCardCommand = new RelayCommand(async () => await OpenRaceCard());
			ShowRaceResultCommand = new RelayCommand(async () => await OpenRaceResult());
		}

		#endregion

		/// <summary>
		/// Attempts to log the user in
		/// </summary>
		/// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
		/// <returns></returns>
		public async Task OpenRaceResult()
		{
			((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.RaceResult;

			await Task.Delay(1);
		}

		/// <summary>
		/// Takes the user to the register page
		/// </summary>
		/// <returns></returns>
		public async Task OpenRaceCard()
		{
			// TODO: Go to register page?
			((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.RaceCard;

			await Task.Delay(1);
		}
	}
}

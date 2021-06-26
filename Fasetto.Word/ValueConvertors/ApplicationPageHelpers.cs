﻿using GreyBase.DataModels;
using GreyBase;

using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Controls;

namespace GreyBase
{
	/// <summary>
	/// Converts the <see cref="ApplicationPage"/> to an actual view/page
	/// </summary>
	public static class ApplicationPageHelpers
	{
		/// <summary>
		/// Takes a <see cref="ApplicationPage"/> and a view model, if any, and creates the desired page
		/// </summary>
		/// <param name="page"></param>
		/// <param name="viewModel"></param>
		/// <returns></returns>
		public static Page ToBasePage(this ApplicationPage page, object viewModel = null)
		{
			// Find the appropriate page
			switch (page)
			{
				//case ApplicationPage.Greyhound:
				//	return new GreyhoundProfilePage(viewModel as GreyhoundProfileViewModel);
				//case ApplicationPage.Login:
				//    return new LoginPage(viewModel as LoginViewModel);

				//case ApplicationPage.Register:
				//    return new RegisterPage(viewModel as RegisterViewModel);

				//case ApplicationPage.Chat:
				//    return new ChatPage(viewModel as ChatMessageListViewModel);

				default:
					Debugger.Break();
					return null;
			}
		}

		/// <summary>
		/// Converts a <see cref="BasePage"/> to the specific <see cref="ApplicationPage"/> that is for that type of page
		/// </summary>
		/// <param name="page"></param>
		/// <returns></returns>
		public static ApplicationPage ToApplicationPage(this BasePage page)
		{
			// Find application page that matches the base page
			//if (page is ChatPage)
			//    return ApplicationPage.Chat;

			//if (page is LoginPage)
			//    return ApplicationPage.Login;

			//if (page is RegisterPage)
			//    return ApplicationPage.Register;

			// Alert developer of issue
			Debugger.Break();
			return default(ApplicationPage);
		}
	}
}
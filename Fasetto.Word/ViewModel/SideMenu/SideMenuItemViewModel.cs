using GreyBase.DataModels;
using System.Collections.Generic;
using System.Windows.Input;
using System;

namespace GreyBase
{
	public class SideMenuItemViewModel : BaseViewModel
	{
		public string Name { get; set; }

		public string IconPath { get; set; }

		public bool IsActive { get; set; } = false;


		#region Public Commands

		/// <summary>
		/// Opens the current message thread
		/// </summary>
		public ICommand OpenMessageCommand { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public SideMenuItemViewModel()
		{
			// Create commands
			OpenMessageCommand = new RelayCommand(OpenMessage);
		}

		#endregion

		#region Command Methods

		public void OpenMessage()
		{

			IoC.Application.GoToPage(ApplicationPage.RaceResult);
			//if (Name == "Jesse")
			//{
			//	IoC.Application.GoToPage(ApplicationPage.Login, new LoginViewModel
			//	{
			//		Email = "jesse@helloworld.com"
			//	});
			//	return;
			//}

			//IoC.Application.GoToPage(ApplicationPage.Chat, new ChatMessageListViewModel
			//{
			//	Items = new List<ChatMessageListItemViewModel>
			//	{
			//		new ChatMessageListItemViewModel
			//		{
			//			Message = Message,
			//			Initials = Initials,
			//			MessageSentTime = DateTime.UtcNow,
			//			ProfilePictureRGB = "FF00FF",
			//			SenderName = "Luke",
			//			SentByMe = true,
			//		},
			//		new ChatMessageListItemViewModel
			//		{
			//			Message = "A received message",
			//			Initials = Initials,
			//			MessageSentTime = DateTime.UtcNow,
			//			ProfilePictureRGB = "FF0000",
			//			SenderName = "Parnell",
			//			SentByMe = false,
			//		},                    new ChatMessageListItemViewModel
			//		{
			//			Message = "A received message",
			//			Initials = Initials,
			//			MessageSentTime = DateTime.UtcNow,
			//			ProfilePictureRGB = "FF0000",
			//			SenderName = "Parnell",
			//			SentByMe = false,
			//		},
			//		new ChatMessageListItemViewModel
			//		{
			//			Message = Message,
			//			Initials = Initials,
			//			MessageSentTime = DateTime.UtcNow,
			//			ProfilePictureRGB = "FF00FF",
			//			SenderName = "Luke",
			//			SentByMe = true,
			//		},
			//		new ChatMessageListItemViewModel
			//		{
			//			Message = "A received message",
			//			Initials = Initials,
			//			MessageSentTime = DateTime.UtcNow,
			//			ProfilePictureRGB = "FF0000",
			//			SenderName = "Parnell",
			//			SentByMe = false,
			//		},                    new ChatMessageListItemViewModel
			//		{
			//			Message = "A received message",
			//			Initials = Initials,
			//			MessageSentTime = DateTime.UtcNow,
			//			ProfilePictureRGB = "FF0000",
			//			SenderName = "Parnell",
			//			SentByMe = false,
			//		},
			//	}
			//});
		}

		#endregion

	}
}

using System;

using Xamarin.Forms;

namespace Be.BankVanBreda.Online.UI.Phone
{
	public class SmartPhoneApplication : Application
	{
		public SmartPhoneApplication ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							#if DEBUG
							Text = "Debug Xamarin Forms!"
							#elif PREPRODUCTION
							Text = "PreProduction Baby!"
							#else
							Text = "Welcome to Xamarin Forms!"
							#endif
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


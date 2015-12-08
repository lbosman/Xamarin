using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Be.BankVanBreda.Online.UI.Phone.Presentation;

namespace Be.BankVanBreda.Online.UI.Phone.Register
{
	public partial class SelectLanguagePage : ContentPage
	{
		public SelectLanguagePage (SelectLanguageViewModel selectLanguageViewModel)
		{
			InitializeComponent ();
			BindingContext = selectLanguageViewModel;
		}
	}
}


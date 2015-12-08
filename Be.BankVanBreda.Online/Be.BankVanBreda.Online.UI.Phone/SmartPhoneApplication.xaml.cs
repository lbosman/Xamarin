using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Be.BankVanBreda.Online.UI.Phone.Register;
using Ninject;
using Be.BankVanBreda.Online.Framework;
using Ninject.Modules;

namespace Be.BankVanBreda.Online.UI.Phone
{
	public partial class SmartPhoneApplication : Application
	{
		protected readonly IKernel Kernel;

		public SmartPhoneApplication ()
		{
			InitializeComponent ();

			Kernel = new StandardKernel (NinjectModules);

			MainPage = PageFactory.Get(typeof(SelectLanguagePage));
		}

		public IPageFactory PageFactory
		{
			get
			{
				return Kernel.Get<IPageFactory>();
			}
		}

		private NinjectModule[] NinjectModules
		{
			get
			{
				return new NinjectModule[] { new BaseModule() };
			}
		}
	}
}
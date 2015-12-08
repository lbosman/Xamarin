using System;
using Ninject.Modules;

namespace Be.BankVanBreda.Online.Framework
{
	public class BaseModule : NinjectModule
	{
		public BaseModule ()
		{
		}

		public override void Load()
		{
			Bind<IPageFactory> ().To<PageFactory>().InSingletonScope ();
		}
	}
}


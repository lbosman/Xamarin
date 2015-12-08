using System;
using Xamarin.Forms;
using Ninject;
using Ninject.Parameters;
using System.Diagnostics;

namespace Be.BankVanBreda.Online.Framework
{
	public class PageFactory : IPageFactory
	{
		protected readonly IKernel Kernel;

		public PageFactory(IKernel kernel)
		{
			Kernel = kernel;
		}

		public Page Get(Type page)
		{
			return GetPage(page, null);
		}

		private Page GetPage(Type pageType, object dataContext)
		{
			try
			{
				return Kernel.Get(pageType, new ConstructorArgument("data", dataContext)) as Page;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.ToString());
				Debug.WriteLine("Page Load Exception:");
				LogExceptionMessages(e);

				throw;
			}
		}

		public Page Get<T>(Type page, T data)
		{
			return GetPage(page, data);
		}

		private void LogExceptionMessages(Exception ex)
		{
			if (ex != null)
			{
				if (!String.IsNullOrEmpty(ex.Message))
				{
					Debug.WriteLine(ex.Message);
				}
				if (ex.InnerException != null)
				{
					LogExceptionMessages(ex.InnerException);
				}
			}
		}
	}
}


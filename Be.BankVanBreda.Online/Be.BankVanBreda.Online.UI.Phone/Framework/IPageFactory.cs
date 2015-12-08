using System;
using Xamarin.Forms;

namespace Be.BankVanBreda.Online.Framework
{
	public interface IPageFactory
	{
		Page Get(Type page);
		Page Get<T>(Type page, T data);
	}
}


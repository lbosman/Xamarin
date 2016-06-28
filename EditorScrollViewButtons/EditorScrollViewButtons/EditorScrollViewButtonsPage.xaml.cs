using Xamarin.Forms;

namespace EditorScrollViewButtons
{
	public partial class EditorScrollViewButtonsPage : ContentPage
	{
		int i = 0;

		public EditorScrollViewButtonsPage ()
		{
			InitializeComponent ();
		}

		void Increase_Clicked (object sender, System.EventArgs e)
		{
			MyEditor.Text += string.Format("{0}. Increased\r\n", ++i);
			MyEditor.HeightRequest += 100;
		}

		void Decrease_Clicked (object sender, System.EventArgs e)
		{
			MyEditor.Text += string.Format ("{0}. Decreased\r\n", ++i);
			MyEditor.HeightRequest -= 100;
		}
	}
}


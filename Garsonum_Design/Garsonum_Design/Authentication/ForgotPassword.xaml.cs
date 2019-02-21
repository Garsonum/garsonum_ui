using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Garsonum_Design.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPassword : ContentPage
	{
		public ForgotPassword ()
		{
			InitializeComponent ();
		}

	    private async void Btn_YnHsp_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new SignUp());
        }

	    private async void Btn_Frgt_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new AfterForgot());
        }
	}
}
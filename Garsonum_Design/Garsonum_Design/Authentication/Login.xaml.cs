using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garsonum_Design.Tabs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Garsonum_Design.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

	    private async void Btn_YnHsp_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new SignUp());
        }

	    private async void Btn_FrgtPsswrd_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new ForgotPassword());
        }

	    private async void Btn_GrsYp_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new TabPage());
        }
	}
}
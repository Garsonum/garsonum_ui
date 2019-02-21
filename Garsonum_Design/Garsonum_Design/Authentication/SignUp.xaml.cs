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
	public partial class SignUp : ContentPage
	{
		public SignUp ()
		{
			InitializeComponent ();
		}
        
	    private async void Btn_GrsYp_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Login());
	    }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garsonum_Design.Authentication;
using Xamarin.Forms;

namespace Garsonum_Design
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnGrsYp_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void BtnSgnUp_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        private async void Btn_Mknlr_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Places());
        }
    }
}

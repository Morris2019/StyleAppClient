using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UrbanStyleApp.Authentications
{
    public partial class UserPassCodeReset : ContentPage
    {
        public UserPassCodeReset()
        {
            InitializeComponent();
        }
       
        private async void ResetpassClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(UserSignInPage)}");
        }
    }
}

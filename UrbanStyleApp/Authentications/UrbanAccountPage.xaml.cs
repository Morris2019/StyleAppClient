using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UrbanStyleApp.Authentications
{
    public partial class UrbanAccountPage : ContentPage
    {
        public UrbanAccountPage()
        {
            InitializeComponent();
        }

        public async void UrbanLogin(object sender, EventArgs e)
        {
            var route = $"{nameof(UserSignInPage)}";
            await Shell.Current.GoToAsync(route);
        }
        public async void UrbanSignup(object sender, EventArgs e)
        {
            var route = $"{nameof(UserAccountCreate)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}

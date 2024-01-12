using System;
using System.Collections.Generic;
using UrbanStyleApp.AccountMainPages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UrbanStyleApp.Authentications
{
    public partial class UserSignInPage : ContentPage
    {
        public UserSignInPage()
        {
            InitializeComponent();
        }
        async void UserLoginButton(System.Object sender, System.EventArgs e)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                await Shell.Current.GoToAsync($"//{nameof(AccountHome)}");
            }
            else
            {
                await DisplayAlert("No Internet", "No Internet Connectivity", "OK");
            }
        }
        private async void UserCreateAccountTap(System.Object sender, System.EventArgs e)
        {
            var route = $"{nameof(UserAccountCreate)}";
            await Shell.Current.GoToAsync(route);
        }
        private async void UserPasswordResetTap(object sender, EventArgs e)
        {
            var route = $"{nameof(UserPassCodeReset)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}

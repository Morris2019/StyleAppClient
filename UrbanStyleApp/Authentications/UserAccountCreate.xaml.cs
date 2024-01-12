using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UrbanStyleApp.Authentications
{
    public partial class UserAccountCreate : ContentPage
    {
        public UserAccountCreate()
        {
            InitializeComponent();
        }

        async void SignInPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserSignInPage());
        }
    }
}

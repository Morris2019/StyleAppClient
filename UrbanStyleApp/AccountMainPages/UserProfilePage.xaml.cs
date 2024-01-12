using System;
using System.Collections.Generic;
using UrbanStyleApp.Authentications;
using UrbanStyleApp.ViewModels;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
            //BindingContext = new UserProfilePageViewModel();
        }

        async void logoutClicked(object sender, EventArgs e)
        {
            var route = $"{nameof(SplashFirstPage)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}

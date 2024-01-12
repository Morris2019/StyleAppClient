using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UrbanStyleApp.Authentications
{
    public partial class SplashFirstPage : ContentPage
    {
        public SplashFirstPage()
        {
            InitializeComponent();
        }

        public async void AccountPage(System.Object sender, System.EventArgs e)
        {
            var route = $"{nameof(UrbanAccountPage)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}

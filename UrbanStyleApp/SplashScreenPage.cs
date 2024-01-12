using System;
using UrbanStyleApp.AccountMainPages;
using UrbanStyleApp.Authentications;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UrbanStyleApp
{
    public class SplashScreenPage : ContentPage
    {
        Image SplashImage;
        public SplashScreenPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            //internet connectivity checker


            var sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "UrbanLogo.jpeg",
                WidthRequest = 100,
                HeightRequest = 100,
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(SplashImage);
            this.BackgroundColor = Color.FromHex("#FFFFFF");
            this.Content = sub;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await SplashImage.ScaleTo(1, 1500, Easing.Linear);
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                Application.Current.MainPage = new MainShellPage();
            }
            else
            {
                await DisplayAlert("No Internet", "No Internet Connectivity", "OK");
            }
        }
    }
}

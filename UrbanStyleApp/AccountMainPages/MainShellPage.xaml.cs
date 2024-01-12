using System;
using System.Collections.Generic;
using UrbanStyleApp.Authentications;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class MainShellPage : Shell
    {
        public MainShellPage()
        {
            InitializeComponent();
            //CurrentItem = AccountHome;

            Routing.RegisterRoute(nameof(ItemsDetailsPage), typeof(ItemsDetailsPage));
            Routing.RegisterRoute(nameof(UserSignInPage), typeof(UserSignInPage));
            Routing.RegisterRoute(nameof(UserAccountCreate), typeof(UserAccountCreate));
            Routing.RegisterRoute(nameof(UserPassCodeReset), typeof(UserPassCodeReset));
            Routing.RegisterRoute(nameof(UrbanAccountPage), typeof(UrbanAccountPage));
            Routing.RegisterRoute(nameof(UrbanOfferedService), typeof(UrbanOfferedService));
            Routing.RegisterRoute(nameof(UrbanRequestedService), typeof(UrbanRequestedService));
            Routing.RegisterRoute(nameof(UrbanPaymentsPage), typeof(UrbanPaymentsPage));
            Routing.RegisterRoute(nameof(UrbanCartPage), typeof(UrbanCartPage));
            Routing.RegisterRoute(nameof(GroomersProfilePage), typeof(GroomersProfilePage));
            Routing.RegisterRoute(nameof(ServiceBookingPage), typeof(ServiceBookingPage));
            Routing.RegisterRoute(nameof(GroomersBookingPage), typeof(GroomersBookingPage));
            Routing.RegisterRoute(nameof(ConfirmationPage), typeof(ConfirmationPage));
            Routing.RegisterRoute(nameof(SplashFirstPage), typeof(SplashFirstPage));
        }
    }
}

using System;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class UrbanOfferedService : ContentPage
    {
        public UrbanOfferedService()
        {
            InitializeComponent(); 
        }

        async void ServiceItemSelected(object sender, CurrentItemChangedEventArgs e)
        {
            var route = $"{nameof(ServiceBookingPage)}";
            await Shell.Current.GoToAsync(route);
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var route = $"{nameof(ServiceBookingPage)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}

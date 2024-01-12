using System;
using System.Collections.Generic;
using System.Windows.Input;
using UrbanStyleApp.ViewModels;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class ItemsDetailsPage : ContentPage
    {
       
        public ItemsDetailsPage()
        {
            InitializeComponent();
            BindingContext = new ItemsDetailsPageViewModel();
        }
       async void AdditemCart(object sender, EventArgs e)
        {
            var route = $"{nameof(UrbanCartPage)}";
            await Shell.Current.GoToAsync(route);
        }
        async void UrbanPayment(object sender, EventArgs e)
        {
            await Navigation.ShowPopupAsync(new UrbanPaymentsPage());
           // var route = $"{nameof(UrbanPaymentsPage)}";
           // await Shell.Current.GoToAsync(route);
        }
       

       
    }
}

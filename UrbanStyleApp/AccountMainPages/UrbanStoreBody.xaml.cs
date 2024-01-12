using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class UrbanStoreBody : ContentPage
    {
        public UrbanStoreBody()
        {
            InitializeComponent();
        }
        private async void storeItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var StoreItem = e.CurrentSelection.FirstOrDefault();

            if (StoreItem == null)
            {
                return;
            }

            var route = $"{nameof(ItemsDetailsPage)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}

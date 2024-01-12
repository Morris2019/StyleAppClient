using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UrbanStyleApp.DataModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class UrbanStoreHair : ContentPage
    {
        public ObservableCollection<UrbanUsersModel> TodoItems { get; set; } = new ObservableCollection<UrbanUsersModel>();

        public UrbanStoreHair()
        {
            InitializeComponent();
            GetUserLogs();
        }
        private async Task GetUserLogs()
        {
            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    var httpClient = new HttpClient();
                    var resultJson = await httpClient.GetStringAsync("https://hub.dummyapis.com/employee?noofRecords=10&idStarts=1001");

                    var resultForecasts = JsonConvert.DeserializeObject<UrbanUsersModel[]>(resultJson);

                    UranActivity.ItemsSource = resultForecasts;
                }
                else
                {
                    await DisplayAlert("Data Error", "Please Check Your Network and Try Again", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Data Error", ex.ToString(), "OK");
            }
        }

        private async void storeItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var StoreItem = e.CurrentSelection.FirstOrDefault();

            if(StoreItem == null)
            {
                return;
            }

            var route = $"{nameof(ItemsDetailsPage)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}

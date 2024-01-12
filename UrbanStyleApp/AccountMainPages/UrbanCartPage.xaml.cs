using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UrbanStyleApp.DataModel;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class UrbanCartPage : ContentPage
    {
        public UrbanCartPage()
        {
            InitializeComponent();
            GetUserLogs();
        }

        async void ItemPayment(System.Object sender, System.EventArgs e)
        {
            await Navigation.ShowPopupAsync(new UrbanPaymentsPage());
            // var route = $"{nameof(UrbanPaymentsPage)}";
            // await Shell.Current.GoToAsync(route);
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
    }
}

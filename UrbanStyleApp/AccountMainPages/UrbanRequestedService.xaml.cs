using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UrbanStyleApp.DataModel;
using UrbanStyleApp.EmbeddedFont;
using UrbanStyleApp.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class UrbanRequestedService : ContentPage
    {
        int ratingPoint = 5;
        public UrbanRequestedService()
        {
            InitializeComponent();
            LoadGroomers();
            

        }
        
        private async Task LoadGroomers()
        {
            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    var httpClient = new HttpClient();
                    var resultJson = await httpClient.GetStringAsync("https://hub.dummyapis.com/employee?noofRecords=10&idStarts=1001");

                    var resultForecasts = JsonConvert.DeserializeObject<UrbanUsersModel[]>(resultJson);

                    //UrbangroomerCollect.ItemsSource = resultForecasts;
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

        private async void UrbanPromosCollect(object sender, SelectionChangedEventArgs e)
        {
            var groomerSelect = e.CurrentSelection.FirstOrDefault() as ServiceItemsModel;

            if(groomerSelect == null)
            {
                return;
            }
            else
            {
                
            }
        }
        private async void GroomersServiceCollect(object sender, SelectionChangedEventArgs e)
        {
            var groomerService = e.CurrentSelection.FirstOrDefault() as ServiceItemsModel;

            if(groomerService == null)
            {
                return;
            }
            else
            {
              
            }
        }
        private async void GroomersProfileSelect(object sender, SelectionChangedEventArgs e)
        {
            var groomfirstname = e.CurrentSelection.FirstOrDefault() as GroomersModel;
            if(groomfirstname == null)
            {
                return;
            }
            else
            {
               
                await Shell.Current.GoToAsync($"{nameof(GroomersProfilePage)}?Content={groomfirstname.ImageURL}" );
            }
        }
       

    }
}
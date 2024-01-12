using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UrbanStyleApp.DataModel;
using UrbanStyleApp.EmbeddedFont;
using UrbanStyleApp.Model;
using UrbanStyleApp.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{

    public partial class GroomersProfilePage : ContentPage
    {
        int ratingPoint = 0;
        public GroomersProfilePage()
        {
            InitializeComponent();
            GetGroomersData();
            MyStar1.Text = MaterialIconClass.StarOutline;
            MyStar2.Text = MaterialIconClass.StarOutline;
            MyStar3.Text = MaterialIconClass.StarOutline;
            MyStar4.Text = MaterialIconClass.StarOutline;
            MyStar5.Text = MaterialIconClass.StarOutline;
        }

        private async Task GetGroomersData()
        {
            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    var httpClient = new HttpClient();
                    var resultJson = await httpClient.GetStringAsync("https://hub.dummyapis.com/employee?noofRecords=10&idStarts=1001");

                    var resultForecasts = JsonConvert.DeserializeObject<UrbanUsersModel[]>(resultJson);

                    GroomersProfile.ItemsSource = resultForecasts;
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
        async void GroomerBooking(object sender, EventArgs e)
        {
            var route = $"{nameof(GroomersBookingPage)}";
            await Shell.Current.GoToAsync(route);
        }
        void Rating1(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = MaterialIconClass.Star;
            MyStar2.Text = MaterialIconClass.StarOutline;
            MyStar3.Text = MaterialIconClass.StarOutline;
            MyStar4.Text = MaterialIconClass.StarOutline;
            MyStar5.Text = MaterialIconClass.StarOutline;
            ratingPoint = 1;
        }
        void Rating2(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = MaterialIconClass.Star;
            MyStar2.Text = MaterialIconClass.Star;
            MyStar3.Text = MaterialIconClass.StarOutline;
            MyStar4.Text = MaterialIconClass.StarOutline;
            MyStar5.Text = MaterialIconClass.StarOutline;
            ratingPoint = 2;
        }
        void Rating3(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = MaterialIconClass.Star;
            MyStar2.Text = MaterialIconClass.Star;
            MyStar3.Text = MaterialIconClass.Star;
            MyStar4.Text = MaterialIconClass.StarOutline;
            MyStar5.Text = MaterialIconClass.StarOutline;
            ratingPoint = 3;
        }
        void Rating4(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = MaterialIconClass.Star;
            MyStar2.Text = MaterialIconClass.Star;
            MyStar3.Text = MaterialIconClass.Star;
            MyStar4.Text = MaterialIconClass.Star;
            MyStar5.Text = MaterialIconClass.StarOutline;
            ratingPoint = 4;
        }
        void Rating5(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = MaterialIconClass.Star;
            MyStar2.Text = MaterialIconClass.Star;
            MyStar3.Text = MaterialIconClass.Star;
            MyStar4.Text = MaterialIconClass.Star;
            MyStar5.Text = MaterialIconClass.Star;
            ratingPoint = 5;
        }
    }
}

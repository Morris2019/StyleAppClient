using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UrbanStyleApp.DataModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using UrbanStyleApp.DataServices;
using TcxTools;
using System.Xml.Serialization;
using System.Linq;
using UrbanStyleApp.Authentications;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class AccountHome : ContentPage
    {

        public AccountHome()
        {
            InitializeComponent();

        }
        private async void requestService(object sender, EventArgs e)
        {
            var route = $"{nameof(UrbanRequestedService)}";
            await Shell.Current.GoToAsync(route);
        }
        private async void offeredService(object sender, EventArgs e)
        {
            var route = $"{nameof(UrbanOfferedService)}";
            await Shell.Current.GoToAsync(route);
        }

    }
}

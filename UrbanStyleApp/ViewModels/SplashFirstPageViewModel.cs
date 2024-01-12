using System;
using System.Collections.ObjectModel;
using UrbanStyleApp.Model;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    public class SplashFirstPageViewModel : BindableObject
    {
        private ObservableCollection<ServiceItemsModel> Service;

        public SplashFirstPageViewModel()
        {
            LoadServices();
        }

        public ObservableCollection<ServiceItemsModel> serviceItemms
        {
            get { return Service; }
            set
            {
                Service = value;
                OnPropertyChanged();
            }
        }

        void LoadServices()
        {
            serviceItemms = new ObservableCollection<ServiceItemsModel>() {
                 new ServiceItemsModel
                 {
                     Image="undraw.png",
                     Title = "All our Groomers have acquired a safety Police Report and have no criminal records"
                 },
                 new ServiceItemsModel
                 {
                     Image="undrawmmakeup.png",
                     Title = "Our Groomers undergo Drug & Health Checks"
                 },
            };
        }
    }
}

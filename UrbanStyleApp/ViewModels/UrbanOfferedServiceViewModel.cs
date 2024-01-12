using System;
using System.Collections.ObjectModel;
using UrbanStyleApp.Model;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    public class UrbanOfferedServiceViewModel : BindableObject
    {
        private ObservableCollection<ServiceItemsModel> Service;

        public UrbanOfferedServiceViewModel()
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
                     Image="manicure.png",
                     Title = "Home Manicure Service",
                     Color= Color.Maroon,
                     Price = 100,
                     Description = ""
                 },
                 new ServiceItemsModel
                 {
                     Image="massage.png",
                     Title = "Home Massage Service",
                     Color= Color.Wheat,
                     Price = 250,
                     Description = "Let dolore magna aliqua."
                 },
                 new ServiceItemsModel
                 {
                     Image="pedicureser.png",
                     Title = "Home Pedicure Service",
                     Color= Color.Green,
                     Price = 100,
                     Description = ""
                 },
                 new ServiceItemsModel
                 {
                     Image="makeupser.png",
                     Title = "Home Makeup Service",
                     Color= Color.Red,
                     Price = 300,
                     Description = ""
                 },
                 new ServiceItemsModel
                 {
                     Image="Barbering.png",
                     Title = "Barbering  Service",
                     Color= Color.Aquamarine,
                     Price = 80,
                     Description = ""
                 }
            };
        }
    }
}
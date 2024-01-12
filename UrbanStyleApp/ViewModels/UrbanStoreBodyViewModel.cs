using System;
using System.Collections.ObjectModel;
using UrbanStyleApp.Model;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    public class UrbanStoreBodyViewModel : BindableObject
    {
        private ObservableCollection<ServiceItemsModel> Service;

        public UrbanStoreBodyViewModel()
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
                     Image="agelesselixir.png",
                     Title = "Angeless Elixir",
                     Price = 0.81,
                     Description = ""
                 },
                 new ServiceItemsModel
                 {
                     Image="AMPMMoisturizer.png",
                     Title = "AM/PM Moisturizer",
                     Price = 0.70,
                     Description = "Let dolore magna aliqua."
                 },
                 new ServiceItemsModel
                 {
                     Image="EnzymeExfoliator.png",
                     Title = "Enzime Exfoliator",
                     Price = 0.58,
                     Description = ""
                 },
                 new ServiceItemsModel
                 {
                     Image="facialfoamingcleanser.png",
                     Title = "Facial Foaming Cleanser",
                     Price = 0.90,
                     Description = ""
                 },
                 
            };
        }
    }
}

using System;
using System.Collections.ObjectModel;
using UrbanStyleApp.Model;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    public class UserProfilePageViewModel : BindableObject
    {
        private ObservableCollection<ServiceItemsModel> Service;

        public UserProfilePageViewModel()
        {
            LoadServices();
        }

        public ObservableCollection<ServiceItemsModel> ServiceItems
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
            ServiceItems = new ObservableCollection<ServiceItemsModel>() {
                 new ServiceItemsModel
                 {
                     Image="round_shopping_bag_white_48.png",
                     Title = "My Orders",
                 },
                 new ServiceItemsModel
                 {
                     Image="round_perm_identity_white_48.png",
                     Title = "Profile",
                 },
                 new ServiceItemsModel
                 {
                     Image="pedicure.png",
                     Title = "Payment Methods ",
                 },
                 new ServiceItemsModel
                 {
                     Image="makeup.png",
                     Title = "Help",
                 },
                 new ServiceItemsModel
                 {
                     Image="Barbering.png",
                     Title = "About",
                 }
            };
        }
    }
}

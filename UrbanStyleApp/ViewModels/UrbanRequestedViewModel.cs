using System;
using System.Collections.ObjectModel;
using UrbanStyleApp.Model;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    public class UrbanRequestedViewModel : BindableObject
    {
        private ObservableCollection<ServiceItemsModel> DiscountService;

        private ObservableCollection<ServiceItemsModel> GroomersService;

        private ObservableCollection<GroomersModel> GroomersProfile;

        public UrbanRequestedViewModel()
        {
            LoadDiscountService();
            LoadGroomerService();
            LoadGroomerProfile();
        }

        public ObservableCollection<ServiceItemsModel> DiscountServiceItems
        {
            get { return DiscountService; }
            set
            {
                DiscountService = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ServiceItemsModel> GroomerServiceItems
        {
            get { return GroomersService; }
            set
            {
                GroomersService = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<GroomersModel> GroomerProfileItems
        {
            get { return GroomersProfile; }
            set
            {
                GroomersProfile = value;
                OnPropertyChanged();
            }
        }

        void LoadDiscountService()
        {
            DiscountServiceItems = new ObservableCollection<ServiceItemsModel>() {
                 new ServiceItemsModel
                 {
                     Image="Partyset.png",
                     Title = "Party Set",
                     Description = "Save more than 20% off"
                 },
                 new ServiceItemsModel
                 {
                     Image="Partyset.png",
                     Title = "Party Set",
                     Description = "Save more than 30% off"
                 },
                 new ServiceItemsModel
                 {
                     Image="Partyset.png",
                     Title = "Party Set ",
                     Description = "Save more than 40% off"
                 },
                 new ServiceItemsModel
                 {
                     Image="Partyset.png",
                     Title = "Party Set",
                     Description = "Save more than 50% off"
                 },
                 new ServiceItemsModel
                 {
                     Image="Partyset.png",
                     Title = "Party Set",
                     Description = "Save more than 60% off"

                 }
            };
        }

        void LoadGroomerService()
        {
            GroomerServiceItems = new ObservableCollection<ServiceItemsModel>() {
                 new ServiceItemsModel
                 {
                     Image="Haircut2.png",
                     Title = "Haircut",
                 },
                 new ServiceItemsModel
                 {
                     Image="Makeup.png",
                     Title = "Makeup",
                 },
                 new ServiceItemsModel
                 {
                     Image="nail.png",
                     Title = "Nails",
                 },
                 new ServiceItemsModel
                 {
                     Image="hairstyling.png",
                     Title = "Hair Styling",
                 },
                 new ServiceItemsModel
                 {
                     Image="pedicure.png",
                     Title = "Pedicure",

                 },
                 new ServiceItemsModel
                 {
                     Image="massagetreatment.png",
                     Title = "Massage",

                 }
            };
        }
        
        void LoadGroomerProfile()
        {
            GroomerProfileItems = new ObservableCollection<GroomersModel>() {
                 new GroomersModel
                 {
                     ImageURL="mem2.png",
                     FirstName = "kwame",
                     LastName ="James",
                     Price = "90"
                 },
                 new GroomersModel
                 {
                     ImageURL="mem3.png",
                     FirstName = "Jason",
                     LastName ="Brown",
                     Price = "80"
                 },
                 new GroomersModel
                 {
                     ImageURL="mem4.png",
                     FirstName = "George",
                     LastName = "Venn",
                     Price = "80"

                 },
                new GroomersModel
                 {
                     ImageURL="mem2.png",
                     FirstName = "kwame",
                     LastName ="James",
                     Price = "90"
                 },
                 new GroomersModel
                 {
                     ImageURL="mem3.png",
                     FirstName = "Jason",
                     LastName ="Brown",
                     Price = "80"
                 },
                 new GroomersModel
                 {
                     ImageURL="mem4.png",
                     FirstName = "George",
                     LastName = "Venn",
                     Price = "80"

                 }
            };
        }


    }
}
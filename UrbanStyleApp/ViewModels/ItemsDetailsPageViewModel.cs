using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    public class ItemsDetailsPageViewModel : BindableObject
    {
        int ItemCount;
        string countItems = "1";
        public ItemsDetailsPageViewModel()
        {
            IcreaseItem = new Command(ItemIncrese);
            DecreaseIttem = new Command(ItemDercrease);
          
        }
        public ICommand IcreaseItem { get; set; }
        public ICommand DecreaseIttem { get; set; }

        public string CountItems
        {
            get => countItems;
            set
            {
                if(value == countItems)
                { return; }
                countItems = value;
                OnPropertyChanged();
            }
        }
        void ItemIncrese()
        {
            ItemCount++;
            CountItems = $"{ItemCount}";
        }
        void ItemDercrease()
        {
            ItemCount--;
            CountItems = $"{ItemCount}";
        }
        
    }
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UrbanStyleApp.Model;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    [QueryProperty(nameof(Content), "Contents")]
    public class GroomersProfilePageViewModel : INotifyPropertyChanged
    {
        private string content;
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                if (content != value)
                {
                    //content = value;
                    content = Uri.UnescapeDataString(value ?? string.Empty);
                    NotifyPropertyChanged();
                }
            }
        }
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

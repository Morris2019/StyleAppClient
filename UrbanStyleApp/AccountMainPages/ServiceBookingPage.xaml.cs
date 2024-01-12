using System;
using System.Collections.Generic;
using UrbanStyleApp.ViewModels;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    public partial class ServiceBookingPage : ContentPage
    {
        private List<View> SelectedItems { get; set; }
        public ServiceBookingPage()
        {
            InitializeComponent();
            SelectedItems = new List<View>();
            BindingContext = new ScheduleEventsViewModel();
        }
        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            var l = (Label)sender;

            if (SelectedItems.Count > 0)
            {
                foreach (var v in SelectedItems)  //reset the styling to the original 'unselected' colors
                {
                    if (v.GetType() == typeof(Frame))
                        ((Frame)v).BackgroundColor = Color.Transparent;
                    else if (v.GetType() == typeof(Label))
                        ((Label)v).TextColor = Color.Black;
                }
                SelectedItems.Clear();
            }
            var parent = (Frame)l.Parent;
            parent.BackgroundColor = Color.FromHex("#2196F3");   //set the background color
            SelectedItems.Add(parent);
            foreach (var c in parent.Children)   //option to set additional styling to the child elements
            {
                var child = (Label)c;
                child.TextColor = Color.White;
                SelectedItems.Add(child);
            }
           
        }
        private async void BookService(object sender, EventArgs e)
        {
            var route = $"{nameof(ConfirmationPage)}";
            await Shell.Current.GoToAsync(route);

        }
    }
}

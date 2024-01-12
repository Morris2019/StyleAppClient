using System;
using System.Collections.Generic;
using System.ComponentModel;
using UrbanStyleApp.EmbeddedFont;
using UrbanStyleApp.ViewModels;
using Xamarin.Forms;

namespace UrbanStyleApp.AccountMainPages
{
    [DesignTimeVisible(false)]
    public partial class GroomersBookingPage : ContentPage
    {
        int ratingPoint = 0;
        private List<View> SelectedItems { get; set; }
        public GroomersBookingPage()
        {
            InitializeComponent();
            MyStar1.Text = MaterialIconClass.StarOutline;
            MyStar2.Text = MaterialIconClass.StarOutline;
            MyStar3.Text = MaterialIconClass.StarOutline;
            MyStar4.Text = MaterialIconClass.StarOutline;
            MyStar5.Text = MaterialIconClass.StarOutline;
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
        private async void BookGroomer(object sender, EventArgs e)
        {
            var route = $"{nameof(ConfirmationPage)}";
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

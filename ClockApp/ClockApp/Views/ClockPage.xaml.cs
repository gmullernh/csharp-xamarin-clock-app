using ClockApp.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClockApp.Views
{
    public partial class ClockPage : ContentPage
    {
        public ClockPage()
        {
            InitializeComponent();
            BindingContext = new ClockViewModel();
        }
    }
}
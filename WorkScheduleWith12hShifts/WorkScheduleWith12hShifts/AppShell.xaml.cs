using System;
using System.Collections.Generic;
using WorkScheduleWith12hShifts.ViewModels;
using WorkScheduleWith12hShifts.Views;
using Xamarin.Forms;

namespace WorkScheduleWith12hShifts
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//AboutPage");
            //await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

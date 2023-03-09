using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkScheduleWith12hShifts.Models;
using WorkScheduleWith12hShifts.ViewModels;
using WorkScheduleWith12hShifts.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkScheduleWith12hShifts.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
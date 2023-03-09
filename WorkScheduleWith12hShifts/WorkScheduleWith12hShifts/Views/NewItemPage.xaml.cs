using System;
using System.Collections.Generic;
using System.ComponentModel;
using WorkScheduleWith12hShifts.Models;
using WorkScheduleWith12hShifts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkScheduleWith12hShifts.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
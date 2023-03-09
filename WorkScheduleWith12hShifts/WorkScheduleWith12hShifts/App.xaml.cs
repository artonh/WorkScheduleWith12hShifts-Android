using System;
using WorkScheduleWith12hShifts.Services;
using WorkScheduleWith12hShifts.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkScheduleWith12hShifts
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

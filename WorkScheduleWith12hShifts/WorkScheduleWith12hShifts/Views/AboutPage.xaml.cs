using System;
using System.Collections.Generic;
using System.ComponentModel;
using WorkingHoursWShifts12Day24Off12Night48Off;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkScheduleWith12hShifts.Views
{

    public partial class AboutPage : ContentPage
    { 
        /// <summary>
        /// It checks the intervals, based on the formula: Working 12 hours during the day, rest 24 hours, 
        /// working 12h night and rest for the 48h.
        /// </summary>
        public AboutPage()
        {
            InitializeComponent();
            PaintSwitch(dayNightSwitch);

            startDatePicker.DateSelected += startDatePicker_DateSelected;
            checkDatePicker.DateSelected += checkDatePicker_DateSelected;
        }

        private void startDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            checkDatePicker.MinimumDate = startDatePicker.Date;
            //checkDatePicker.Date = startDatePicker.Date;
        }

        private void checkDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            OnCheckClicked(sender, e);
        }


        void OnCheckClicked(object sender, EventArgs args)
        {
            try
            {
                var startDate = startDatePicker.Date;
                var checkDate = checkDatePicker.Date;

                if (!dayNightSwitch.IsToggled)
                {
                    startDate = startDate.AddHours(-24);
                }

                WorkingHours wschedule = new WorkingHours(startDate);

                var result = wschedule.GetWorkingType(checkDate);

                resultLabel.Text = result.ToString();
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }

        private void OnToggled(object sender, ToggledEventArgs e)
        {
            var switchControl = (Switch)sender;

            PaintSwitch(switchControl);
        }

        private static void PaintSwitch(Switch switchControl)
        {
            if (switchControl.IsToggled)
            {
                switchControl.ThumbColor = Color.ForestGreen;
                switchControl.OnColor = Color.Green;
            }
            else
            {
                switchControl.ThumbColor = Color.Default;
                switchControl.OnColor = Color.Default;
            }
        }
    }
}
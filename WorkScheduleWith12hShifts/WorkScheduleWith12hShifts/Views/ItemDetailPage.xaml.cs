using System.ComponentModel;
using WorkScheduleWith12hShifts.ViewModels;
using Xamarin.Forms;

namespace WorkScheduleWith12hShifts.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
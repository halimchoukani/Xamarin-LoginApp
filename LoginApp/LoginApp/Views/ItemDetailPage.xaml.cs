using LoginApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginApp.Views
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
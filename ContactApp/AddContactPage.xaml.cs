using ContactApp.ViewModels;
using Microsoft.Maui.Controls;

namespace ContactApp
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
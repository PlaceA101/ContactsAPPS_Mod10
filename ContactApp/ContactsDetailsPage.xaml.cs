using ContactApp.ViewModels;

namespace ContactApp;

public partial class ContactsDetailsPage : ContentPage
{
    public ContactsDetailsPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

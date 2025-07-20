using ContactApp.ViewModels;

namespace ContactApp;
public partial class ContactsPage : ContentPage
{
    public ContactsPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

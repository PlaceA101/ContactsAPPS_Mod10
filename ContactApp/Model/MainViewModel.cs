using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactApp.Models;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace ContactApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string email;

    [ObservableProperty]
    string phone;

    [ObservableProperty]
    string description;

    [ObservableProperty]
    Models.Contact selectedContact;

    public ObservableCollection<Models.Contact> Contacts { get; } = new();

    [RelayCommand]
    async Task SaveContact()
    {
        var newContact = new Models.Contact
        {
            Name = Name,
            Email = Email,
            Phone = Phone,
            Description = Description
        };

        Contacts.Add(newContact);

        Name = Email = Phone = Description = string.Empty;

        await Shell.Current.GoToAsync("ContactsPage");
    }

    [RelayCommand]
    async Task GoToDetails(Models.Contact contact)
    {
        SelectedContact = contact;
        await Shell.Current.GoToAsync(nameof(ContactsDetailsPage));
    }

    [RelayCommand]
    async Task GoToAddContact() => await Shell.Current.GoToAsync("AddContactPage");
}

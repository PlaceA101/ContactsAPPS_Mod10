using System.Collections.ObjectModel;
using ContactsApp_placean.Models;

namespace ContactsApp_placean;

public partial class ContactsPage : ContentPage
{
    public ObservableCollection<Group<string, Models.Contact>> GroupedContacts { get; set; }

    public ContactsPage()
    {
        InitializeComponent();
        LoadContacts();
    }

    void LoadContacts()
    {
        var contacts = new List<Models.Contact>
        {
            new Models.Contact { Name = "Alice Adams", Email = "alice@example.com", PhoneNumber = "123-456-7890", Description = "HR Manager" },
            new Models.Contact { Name = "Aaron Allan", Email = "aaron@example.com", PhoneNumber = "234-567-8901", Description = "Software Engineer" },
            new Models.Contact { Name = "Amanda Avery", Email = "amanda@example.com", PhoneNumber = "345-678-9012", Description = "UX Designer" },
            new Models.Contact { Name = "Andrew Archer", Email = "andrew@example.com", PhoneNumber = "456-789-0123", Description = "Marketing Lead" },
            new Models.Contact { Name = "Ariel Anderson", Email = "ariel@example.com", PhoneNumber = "567-890-1234", Description = "Content Strategist" },

            new Models.Contact { Name = "Brandon Blake", Email = "brandon@example.com", PhoneNumber = "678-901-2345", Description = "Graphic Designer" },
            new Models.Contact { Name = "Brianna Bell", Email = "brianna@example.com", PhoneNumber = "789-012-3456", Description = "Business Analyst" },
            new Models.Contact { Name = "Benjamin Brooks", Email = "ben@example.com", PhoneNumber = "890-123-4567", Description = "Data Scientist" },
            new Models.Contact { Name = "Bethany Brown", Email = "bethany@example.com", PhoneNumber = "901-234-5678", Description = "Recruiter" },
            new Models.Contact { Name = "Blake Barnett", Email = "blake@example.com", PhoneNumber = "012-345-6789", Description = "QA Engineer" },

            new Models.Contact { Name = "Carlos Cruz", Email = "carlos@example.com", PhoneNumber = "123-654-7890", Description = "Sales Rep" },
            new Models.Contact { Name = "Catherine Clark", Email = "catherine@example.com", PhoneNumber = "234-765-8901", Description = "Customer Support" },
            new Models.Contact { Name = "Caleb Collins", Email = "caleb@example.com", PhoneNumber = "345-876-9012", Description = "DevOps Engineer" },
            new Models.Contact { Name = "Charlotte Chambers", Email = "charlotte@example.com", PhoneNumber = "456-987-0123", Description = "CEO" },
            new Models.Contact { Name = "Connor Campbell", Email = "connor@example.com", PhoneNumber = "567-098-1234", Description = "Account Manager" },

        };

        var grouped = contacts
            .GroupBy(c => c.Name[0].ToString().ToUpper())
            .OrderBy(g => g.Key)
            .Select(g => new Group<string, Models.Contact>(g.Key, g.OrderBy(c => c.Name)));

        GroupedContacts = new ObservableCollection<Group<string, Models.Contact>>(grouped);
        ContactsCollectionView.ItemsSource = GroupedContacts;
    }

    async void OnContactSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Models.Contact selectedContact)
        {
            await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
            ContactsCollectionView.SelectedItem = null;
        }
    }
}
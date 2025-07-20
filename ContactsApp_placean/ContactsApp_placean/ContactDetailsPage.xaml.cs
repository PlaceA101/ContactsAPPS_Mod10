using ContactsApp_placean.Models;
namespace ContactsApp_placean;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage(Models.Contact contact)
    {
        InitializeComponent();
        PhotoImage.Source = contact.Photo;
        NameLabel.Text = contact.Name;
        EmailLabel.Text = $"Email: {contact.Email}";
        PhoneLabel.Text = $"Phone: {contact.PhoneNumber}";
        DescriptionLabel.Text = $"Description: {contact.Description}";
    }

    async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
using PasswortVerwalterApp.Models;
using PasswortVerwalterApp.Services;
namespace PasswortVerwalterApp.Views;

public partial class DetailPage : ContentPage
{
    Eintrag eintrag;
    public DetailPage()
	{
		InitializeComponent();
	}
    public DetailPage(Eintrag eintrag)
    {
        InitializeComponent();
        BindingContext = this;
        konto.Text = eintrag.Konto;
        email.Text = eintrag.EMail;
        benutzername.Text = eintrag.Benutzername;
        passwort.Text = eintrag.Passwort;
        this.eintrag = eintrag;
    }
    private async void Delete(object sender, EventArgs e)
    {
        await EintragService.DeleteEintrag(eintrag);
        await Navigation.PopAsync();
    }

    private async void Return(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
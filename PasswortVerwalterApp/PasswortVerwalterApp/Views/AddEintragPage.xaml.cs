using PasswortVerwalterApp.Services;
namespace PasswortVerwalterApp.Views;

public partial class AddEintragPage : ContentPage
{
    private string _konto;
    private string _email;
    private string _passwort;
    private string _benutzername;
    public AddEintragPage()
	{
		InitializeComponent();
	}
    private void EntryKonto(object sender, TextChangedEventArgs e)
    {
        _konto = konto.Text;
    }
    private void EntryEMail(object sender, TextChangedEventArgs e)
    {
        _email = email.Text;
    }
    private void EntryBenutzername(object sender, TextChangedEventArgs e)
    {
        _benutzername = benutzername.Text;
    }
    private void EntryPasswort(object sender, TextChangedEventArgs e)
    {
        _passwort = passwort.Text;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await EintragService.AddEintrag(_konto, _email, _benutzername, _passwort);
        await Navigation.PopAsync();
    }
}
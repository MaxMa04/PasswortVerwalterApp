using PasswortVerwalterApp.ViewModels;

namespace PasswortVerwalterApp.Views;

public partial class HomePage : ContentPage
{
	EintragViewModel vm;
	public HomePage()
	{
		InitializeComponent();
		vm = BindingContext as EintragViewModel;
	}
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await vm.Refresh();
    }
    private async void AddEintrag(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new AddEintragPage());
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using PasswortVerwalterApp.Models;
using PasswortVerwalterApp.Services;
using PasswortVerwalterApp.Views;

namespace PasswortVerwalterApp.ViewModels
{
    public class EintragViewModel
    {
        public ObservableRangeCollection<Eintrag> Eintraege { get; set; }

        public EintragViewModel()
        {
            Eintraege = new ObservableRangeCollection<Eintrag>();

        }


        public async Task Refresh()
        {
            Eintraege.Clear();
            var eintraege = await EintragService.GetEintraege();
            Eintraege.AddRange(eintraege);
        }

        public ICommand SelectedItemCommand => new Microsoft.Maui.Controls.Command<Eintrag>(async (eintragdetail) =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DetailPage(eintragdetail));
        });
    }
}

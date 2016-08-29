using IQStar.Model;
using IQStar.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class Konwersacja : ContentPage
    {
        private KonwersacjaViewModel _konwersacjaViewModel;
        public Konwersacja(Znajomy znajmomy)
        {
            InitializeComponent();
            _konwersacjaViewModel = new KonwersacjaViewModel();
            BindingContext = _konwersacjaViewModel;
        }
        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {

            if (await DisplayAlert("Potwierdzenie", "Wysłać wiadomość?", "Tak", "Nie"))
            {
                editor.Text = null;
            };
        }
    }
}

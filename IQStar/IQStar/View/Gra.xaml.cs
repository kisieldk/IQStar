using IQStar.Services;
using IQStar.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class Gra : ContentPage
    {
        private int _czas = 60;
        private bool _licz = true;
        private GraViewModel _graViewModel;
        public Gra(string przeciwnik)
        {
            InitializeComponent();
            _graViewModel = new GraViewModel(przeciwnik);
            BindingContext = _graViewModel;
            AktualizujCzasGry();

        }

        public  void AktualizujCzasGry()
        {
            Device.StartTimer(new TimeSpan(0, 0, 1), () => {
                // do something every 1 seconds
                _czas--;
                Device.BeginInvokeOnMainThread(() => {
                    // interact with UI elements
                  
                    lblCzas.Text =_czas.ToString();
                });

                if (_czas == 0)
                {
                    _licz = false;
                    _graViewModel.LiczPunkty();
                     DisplayAlert("Wynik gry", _graViewModel.WynikGry(), "Ok");
                }
                return _licz; // runs again, or false to stop
            });
        }

       private async void OnButtonClicked(object sender, EventArgs e)
        {
            _licz = false;
            _graViewModel.LiczPunkty();
            await DisplayAlert("Wynik gry", _graViewModel.WynikGry(),"Ok");
        }
    }
}

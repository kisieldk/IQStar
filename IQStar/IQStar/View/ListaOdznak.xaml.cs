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
    public partial class ListaOdznak : ContentPage
    {
        private OdznakaViewModel _odznakaViewModel;
        public ListaOdznak()
        {
            InitializeComponent();
            _odznakaViewModel = new OdznakaViewModel();
           
            BindingContext = _odznakaViewModel;
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var odznaka = e.Item as Odznaka;
            //await Navigation.PushAsync(new OdzankaSzczegoly(odznaka));
            if (e == null) return; // has been set to null, do not 'process' tapped event
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}

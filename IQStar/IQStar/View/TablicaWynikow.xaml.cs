using IQStar.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class TablicaWynikow : ContentPage
    {
        private TablicaWynikowViewModel _tablicaWynikowViewModel;
        public TablicaWynikow()
        {
            InitializeComponent();
            _tablicaWynikowViewModel = new TablicaWynikowViewModel();
            BindingContext = _tablicaWynikowViewModel;
        }
        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}

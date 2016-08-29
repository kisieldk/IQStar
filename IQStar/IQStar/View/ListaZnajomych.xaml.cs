using IQStar.Model;
using IQStar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class ListaZnajomych : ContentPage
    {
        //private ZnajomyViewModel _znajomyViewModel;
        public ListaZnajomych()
        {
            InitializeComponent();
            // _znajomyViewModel = new ZnajomyViewModel();
            BindingContext = Znajomi.ZnajomyViewModel;// _znajomyViewModel;
        }
        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            var user = e.Item as Znajomy;
            await Navigation.PushAsync(new ZnajomySzczegoly(user));
        }
    }
}

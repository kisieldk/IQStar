using IQStar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class ListaZaproszen : ContentPage
    {
        public ListaZaproszen()
        {
            InitializeComponent();
            BindingContext = Znajomi.ZnajomyViewModel;
        }
        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            var user = e.Item as Zaproszenie;
            await DisplayAlert("Akceptacja zaproszenia",string.Format("Czy akceptujesz zaproszenie od {0}?",user.Login),"Tak","Nie");
        }
    }
}

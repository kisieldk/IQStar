using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class WyborGry : ContentPage
    {
        public WyborGry()
        {
            InitializeComponent();
            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (s, e) => GoToGra();
            android.GestureRecognizers.Add(tgr);
            znajomy.GestureRecognizers.Add(tgr);
            przeciwnik.GestureRecognizers.Add(tgr);
 
        }
        private async void GoToGra()
        {
        
            await Navigation.PushAsync(new Gra("Android"));
        }

    }
}

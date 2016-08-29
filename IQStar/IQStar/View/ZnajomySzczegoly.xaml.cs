using IQStar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class ZnajomySzczegoly : ContentPage
    {
        private Znajomy _zan;
        public ZnajomySzczegoly(Znajomy znajomy)
        {
            InitializeComponent();
            _zan = znajomy;
            BindingContext = znajomy;
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Konwersacja(_zan));
        }
    }
}

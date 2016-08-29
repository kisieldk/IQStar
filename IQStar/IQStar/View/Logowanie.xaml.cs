using IQStar.View.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class Logowanie : ContentPage
    {
        public Logowanie()
        {
            InitializeComponent();
           
        }
        public  void btnLogowanie_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Menu();
        
        }
    }
}

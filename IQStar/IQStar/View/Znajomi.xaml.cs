using IQStar.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View
{
    public partial class Znajomi : TabbedPage
    {
        public static ZnajomyViewModel ZnajomyViewModel = new ZnajomyViewModel();
        public Znajomi()
        {
            InitializeComponent();
        }
    }
}

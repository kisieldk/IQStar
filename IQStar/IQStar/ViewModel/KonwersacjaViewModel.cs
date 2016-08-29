using IQStar.Model;
using IQStar.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQStar.ViewModel
{
    public class KonwersacjaViewModel : BindableObjecBase
    {
        private ObservableCollection<Konwersacja> _wiadomosci = new ObservableCollection<Konwersacja>();

        public ObservableCollection<Konwersacja> Wiadomosci
        {
            get { return _wiadomosci; }

        }


        public KonwersacjaViewModel()
        {
            _wiadomosci = ApiServices.GetKonwersacja();
    
        }
    }
}

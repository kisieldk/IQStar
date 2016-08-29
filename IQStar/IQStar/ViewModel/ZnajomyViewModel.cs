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
    public class ZnajomyViewModel : BindableObjecBase
    {
        private ObservableCollection<Znajomy> _listaZnajomych = new ObservableCollection<Znajomy>();

        public ObservableCollection<Znajomy> ListaZnajomych
        {
            get { return _listaZnajomych; }

        }
        private ObservableCollection<Zaproszenie> _listaZaproszen = new ObservableCollection<Zaproszenie>();

        public ObservableCollection<Zaproszenie> ListaZaproszen
        {
            get { return _listaZaproszen; }

        }

        public ZnajomyViewModel()
        {
            _listaZnajomych = ApiServices.GetZnajomi();
            _listaZaproszen = ApiServices.GetZaproszenia();
        }
    }
}

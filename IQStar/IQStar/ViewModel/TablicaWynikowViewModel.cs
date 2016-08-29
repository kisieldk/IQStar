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
    public class TablicaWynikowViewModel : BindableObjecBase
    {
        private ObservableCollection<Uzytkownik> _listaUzytkownikow = new ObservableCollection<Uzytkownik>();

        public ObservableCollection<Uzytkownik> ListaUzytkownikow
        {
            get { return _listaUzytkownikow; }

        }

        public TablicaWynikowViewModel()
        {
            _listaUzytkownikow = ApiServices.GetUzytkownik();
        }
    }
}

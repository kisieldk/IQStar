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
    public class OdznakaViewModel : BindableObjecBase
    {
        private ObservableCollection<Odznaka> _listaOdznak = new ObservableCollection<Odznaka>();

        public ObservableCollection<Odznaka> ListaOdznak
        {
            get { return _listaOdznak; }

        }

        public OdznakaViewModel()
        {
            _listaOdznak = ApiServices.GetOdznaki();
        }
    }
}

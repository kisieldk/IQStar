using IQStar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQStar.ViewModel
{
    public class GraViewModel : BindableObjecBase
    {
        private string przeciwnik;
        public string Przeciwnik {
            set
            {
                if (przeciwnik != value)
                {
                    przeciwnik = value;
                    RaisePropertyChanged("Przeciwnik");
                }
            }
            get
            {
                return przeciwnik;
            }
        }
        private int liczba1pyt1;
        private int liczba2pyt1;
        private int liczba1pyt2;
        private int liczba2pyt2;
        private int liczba1pyt3;
        private int liczba2pyt3;
        private string pyt1;
        private string pyt2;
        private string pyt3;
        private string odp1;
        private string odp2;
        private string odp3;
        public string Pyt1 {
            set
            {
                if (pyt1 != value)
                {
                    pyt1 = value;
                    RaisePropertyChanged("Pyt1");
                 
                }
            }
            get
            {
                return pyt1;
            }
        }
        public string Pyt2 {
            set
            {
                if (pyt2 != value)
                {
                    pyt2 = value;
                    RaisePropertyChanged("Pyt2");
                }
            }
            get
            {
                return pyt2;
            }
        }
        public string Pyt3 {
            set
            {
                if (pyt3 != value)
                {
                    pyt3 = value;
                    RaisePropertyChanged("Pyt3");
                }
            }
            get
            {
                return pyt3;
            }
        }
        public string Odp1 {
            set
            {
                if (odp1 != value)
                {
                    odp1 = value;
                    RaisePropertyChanged("Odp1");
                }
            }
            get
            {
                return odp1;
            }
        }
        public string Odp2 {
            set
            {
                if (odp2 != value)
                {
                    odp2 = value;
                    RaisePropertyChanged("Odp2");
                }
            }
            get
            {
                return odp2;
            }
        }
        public string Odp3 {
            set
            {
                if (odp3 != value)
                {
                    odp3 = value;
                    RaisePropertyChanged("Odp3");
                }
            }
            get
            {
                return odp3;
            }
        }
        private char znak1;
        private char znak2;
        private char znak3;
        private int LiczbaPunktow;

        public GraViewModel(string przeciwnik)
        {
            this.przeciwnik = przeciwnik;
            liczba1pyt1 = LosujLiczbe();
            liczba2pyt1 = LosujLiczbe();
            znak1 = LosujZnak();
            pyt1 = BudujPytanie(liczba1pyt1, liczba2pyt1, znak1);

            liczba1pyt2 = LosujLiczbe();
            liczba2pyt2 = LosujLiczbe();
            znak2 = LosujZnak();
            pyt2 = BudujPytanie(liczba1pyt2, liczba2pyt2, znak2);

            liczba1pyt3 = LosujLiczbe();
            liczba2pyt3 = LosujLiczbe();
            znak3 = LosujZnak();
            pyt3 = BudujPytanie(liczba1pyt3, liczba2pyt3, znak3);
        }

        public string WynikGry()
        {
            string wynik = "Wygrana";

            int[] znaki = { 10,20,30 };
            Random r = new Random();
            int znak = r.Next(0, 3);

            if (LiczbaPunktow < znaki[znak])
            {
                wynik = "Przegrana";
            }
            else if (LiczbaPunktow == znaki[znak])
            {
                wynik = "Remis";
            }
            return string.Format("{0}! \nTwoje punkty: {1} \nPunkty przeciwnika {2}", wynik, LiczbaPunktow, znaki[znak]);
        }

        private int WalidujOdp(string odp)
        {
            int od = -1000;
            if (string.IsNullOrEmpty(odp) || string.IsNullOrWhiteSpace(odp))
            {
                return od;
            }
            else return Int32.Parse(odp);
        }
        public int LiczPunkty()
        {
            int punkty = 0;

            if (znak1 == '+')
            {
                if ((liczba1pyt1 + liczba2pyt1) == WalidujOdp(Odp1))
                {
                    punkty += 10;
                }

            }
            else if ((liczba1pyt1 - liczba2pyt1) == WalidujOdp(Odp1))
            {
                punkty += 10;
            }

            if (znak2 == '+')
            {
                if ((liczba1pyt2 + liczba2pyt2) == WalidujOdp(Odp2))
                {
                    punkty += 10;
                }

            }
            else if ((liczba1pyt2 - liczba2pyt2) == WalidujOdp(Odp2))
            {
                punkty += 10;
            }

            if (znak3 == '+')
            {
                if ((liczba1pyt3 + liczba2pyt3) == WalidujOdp(Odp3))
                {
                    punkty += 10;
                }

            }
            else if ((liczba1pyt3 - liczba2pyt3) == WalidujOdp(Odp3))
            {
                punkty += 10;
            }
            LiczbaPunktow = punkty;
            return punkty;
        }
        private int LosujLiczbe()
        {
            Random r = new Random();
            int l = r.Next(1, 21);      
            while (wylosowaneL.Contains(l))
            {
                l = r.Next(1, 21);
       
            }
            wylosowaneL.Add(l);
            return l;
        }

        private char LosujZnak()
        {
            char[] znaki = { '+', '-' };
            Random r = new Random();
            int znak = r.Next(0, 2);
            return znaki[znak];
        }
        private string BudujPytanie(int l1, int l2, char znak)
        {
            string pytanie = "";
            if (l1 < l2)
            {
                pytanie = string.Format("{0} {1} {2} = ", l2, znak, l1);
            }
            else pytanie = string.Format("{0} {1} {2} = ", l1, znak, l2);

            return pytanie;
        }
        private List<int> wylosowaneL = new List<int>();
    }
}

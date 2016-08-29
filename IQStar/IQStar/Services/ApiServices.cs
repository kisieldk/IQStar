using IQStar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQStar.Services
{
    public static class ApiServices
    {

        public static ObservableCollection<Odznaka> GetOdznaki()
        {
            ObservableCollection<Odznaka> _listaOdznak = new ObservableCollection<Odznaka>()
            {
                 new Odznaka() { NazwaOdznaki = "Mistrz", Opis="Rozegraj 100 gier", Postep=0.3,Zdobyta=false},
                   new Odznaka() { NazwaOdznaki = "Początkujący", Opis="Wygraj 10 gier", Postep=0.1,Zdobyta=false},
                     new Odznaka() { NazwaOdznaki = "Przyjaciel", Opis="Zaproś 20 znajomych", Postep=0.4,Zdobyta=false},
                       new Odznaka() { NazwaOdznaki = "Waleczny", Opis="Nie przegraj 5 gier podrząd", Postep=1,Zdobyta=true},

            };
            return _listaOdznak;
        }
        public static ObservableCollection<Znajomy> GetZnajomi()
        {
            ObservableCollection<Znajomy> _listaOdznak = new ObservableCollection<Znajomy>()
            {
                new Znajomy() { Login="majka", OstatniKonwersacja="2016-08-20"},
                   new Znajomy() { Login="kowalik", OstatniKonwersacja="2016-07-25"},
                     new Znajomy() { Login="lotos", OstatniKonwersacja="2016-06-14"},
                         new Znajomy() { Login="adamskki", OstatniKonwersacja="2016-05-05"}

            };
            return _listaOdznak;
        }
        public static ObservableCollection<Zaproszenie> GetZaproszenia()
        {
            ObservableCollection<Zaproszenie> _listaOdznak = new ObservableCollection<Zaproszenie>()
            {
                 new Zaproszenie() {  Login="adamk", DataZaproszenia="2016-08-12"},
                   new Zaproszenie() { Login="pamelka", DataZaproszenia="2016-08-10"},
                     new Zaproszenie() { Login="witek", DataZaproszenia="2016-07-25"}
                      

            };
            return _listaOdznak;
        }
        public static ObservableCollection<Uzytkownik> GetUzytkownik()
        {
            ObservableCollection<Uzytkownik> _listaOdznak = new ObservableCollection<Uzytkownik>()
            {
                 new Uzytkownik() {Login = "kowalik", Punkty=356, LiczbaGrier=30, PozycjaIco="jeden.png"},
                   new Uzytkownik() { Login = "jaTest", Punkty=300, LiczbaGrier=28, PozycjaIco="dwa.png"},
                     new Uzytkownik() { Login = "majka", Punkty=268, LiczbaGrier=25, PozycjaIco="trzy.png"},
                       new Uzytkownik() { Login = "lotos", Punkty=236, LiczbaGrier=22, PozycjaIco="cztery.png"},
                         new Uzytkownik() { Login = "adamskki", Punkty=222, LiczbaGrier=21, PozycjaIco="piec.png"}

            };
            return _listaOdznak;
        }
        public static ObservableCollection<Konwersacja> GetKonwersacja()
        {
            ObservableCollection<Konwersacja> _lista = new ObservableCollection<Konwersacja>()
            {
                 new Konwersacja() {Autor = "kowalik", Tresc="Cześć! Co u Ciebie?", Czas="2016-08-10", MsgColor="#c3c3c3"},//#c3c3c3
                   new Konwersacja() { Autor = "jaTest", Tresc="Cześć! Super a u Ciebie?", Czas="2016-08-10", MsgColor="#727272"},//#727272
                     new Konwersacja() { Autor = "kowalik", Tresc="Też, masz czas na parę gier?", Czas="2016-08-10", MsgColor="#c3c3c3"},
                       new Konwersacja() { Autor = "jaTest", Tresc="Pewnie! Dokończę obiad i zaczynamy!", Czas="2016-08-10", MsgColor="#727272"},
                         new Konwersacja() { Autor = "kowalik", Tresc="Ok, to poczekam chwilę ;)", Czas="2016-08-10", MsgColor="#c3c3c3"}

            };
            return _lista;
        }
    }
}

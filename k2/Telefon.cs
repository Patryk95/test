using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2
{
    class Telefon:IDodaj
    {
        private List<Usluga> biling = new List<Usluga>();
        public void DodajPolonczenie(DateTime czas,string numer, int Czasp)
        {
            biling.Add(new Polaczenie(czas, numer,Czasp));   
}
        public void DodajSms(DateTime czas ,string numer)
        {
            biling.Add(new Sms(czas,numer));
        }
        public void DodajInternet(DateTime czas,int iloscMB)
        {
            biling.Add(new Internet(czas,iloscMB));
        }
       /* public override string ToString()
        {
            ////
        }*/

    }

}

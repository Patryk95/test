using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2
{
    interface IDodaj
    {
        void DodajPolonczenie(DateTime czas, string numer, int Czasp);
        void DodajSms(DateTime czas,string numer);
        void DodajInternet(DateTime czas,int iloscMB);
    }
}

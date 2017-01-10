using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2
{
    class Polaczenie : Usluga
    {
        private string numer;
        private int Czasp;
        public override void  ObliczCene()
        {
            cena=Czasp* 0.29;
        }
        public Polaczenie(DateTime czas, string numer, int Czasp )
            :base (czas)
        {
            this.czas = czas;
            this.numer = numer;
            this.Czasp = Czasp;
            ObliczCene();
        }
        public override string ToString()
        {
            return "numer" + numer + " data i godzina rozmowy" + czas + "dłuość trwania" + Czasp + "koszt polaczenia" + cena; 
        }

    }
}

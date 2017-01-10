using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2
{
    class Internet:Usluga
    {
        private int iloscMB;
        public override void ObliczCene()
        {
              cena = iloscMB / 756;
            
        }
        public Internet(DateTime czas, int iloscMB)
            :base(czas)
        {
            this.czas = czas;
            this.iloscMB = iloscMB;
            ObliczCene();
        }
        public override string ToString()
        {
            return " data i godzina rozmowy" + czas + "ilosc MB " + iloscMB + "łączny koszt" + cena;
        }
    }
}

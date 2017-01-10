using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2
{
    class Sms : Usluga
    {
        private string numer;
        public override void ObliczCene()
        {
            cena = 0.15;
           
     }
        public Sms (DateTime czas, string numer)
            :base(czas)
        {
            this.numer = numer;
            ObliczCene();
        }
        public override string ToString()
        {
            return "numer" + numer + " data i godzina rozmowy" + czas + "łączny koszt" + cena;
        }


    }

}

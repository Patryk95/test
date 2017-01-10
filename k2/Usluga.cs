using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2
{
   public abstract class Usluga
    {
        protected double cena;
        protected DateTime czas ;
        public abstract void ObliczCene();
       public Usluga (DateTime czas )
       {
          this.czas = czas;
            
     }
        
    }
}

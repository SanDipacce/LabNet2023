using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public abstract class TransportePublico
    {
     
        public int CantidadPasajeros { get; set; }

        public TransportePublico(int cantPasajeros)
        {
            this.CantidadPasajeros = cantPasajeros;
        }

       
        public abstract string Avanzar();
        public abstract string Detenerse();


       
       
    }
}

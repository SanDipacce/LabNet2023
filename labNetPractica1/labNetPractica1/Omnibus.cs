using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class Omnibus : TransportePublico
    {
        
        public Omnibus(int CantPasajeros) : base(CantPasajeros)
        {
        }



        public override string Avanzar()
        {
            return $" El omnibus se detiene con {CantidadPasajeros} de Pasajeros";
        }

        public override string Detenerse()
        {
            return $" El omnibus se detiene con {CantidadPasajeros} de Pasajeros";
        }
    }
}


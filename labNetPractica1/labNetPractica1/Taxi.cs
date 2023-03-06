using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class Taxi : TransportePublico
    {
        public Taxi(int CantPasajeros) : base(CantPasajeros)
        {
        }

        public override string Avanzar()
        {
            return $" El Taxi Avanza con {CantidadPasajeros} de Pasajeros";
        }

        public override string Detenerse()
        {
            return $" El Taxi se detiene con {CantidadPasajeros} de Pasajeros";
        }
    }
}

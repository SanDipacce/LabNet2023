using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    internal class Program
    {
        
        public static int CantPasajeros { get; private set; }
    

        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese la cantidad de Pasajeros primero para 5 Omnibus, y luego para 5 Taxis");
            int cantidad = 5;
 
            List<TransportePublico> Transporte = new List<TransportePublico>();

            for (int i = 1; i <= cantidad; i++)
            {
                CantPasajeros = Convert.ToInt32(Console.ReadLine());
                Transporte.Add(new Omnibus(CantPasajeros));
                

            }

            for (int i = 1; i <= cantidad; i++)
            {
                CantPasajeros = Convert.ToInt32(Console.ReadLine());
                Transporte.Add(new Taxi(CantPasajeros));

            }
                

            foreach (var item in Transporte)
            {
                Console.WriteLine(item.Avanzar());
                Console.ReadKey();
            }

           
        }
    }
}

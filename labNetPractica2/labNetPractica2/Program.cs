 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int Numero1;
            int Numero2;
            int Numero3;
            string n;
            string c;
            bool esNumero1;
            bool esNumero2;
            bool esNumero3;

            Console.WriteLine("Bienvenido a la calculadora Virtual");
            do
            {
                Console.WriteLine("Por favor ingrese un numero");
                n = Console.ReadLine();
                esNumero1 = int.TryParse(n, out Numero1);
                if (esNumero1 == false)
                {
                    Console.WriteLine("Error!!! seguro ingreso una letra o nada, debe ingrese un numero");
                }
                else
                {
                    continue;
                }
            }
            while (!esNumero1);
            Console.WriteLine($"Ingresaste este numero: {Numero1} ");
            Console.WriteLine("Por Favor ingrese otro numero: ");
            do
            {
                n = Console.ReadLine();
                esNumero2 = int.TryParse(n, out Numero2);
                if (esNumero2 == false)
                {
                    Console.WriteLine("Error!!! seguro ingreso una letra o nada, debe ingrese un numero");
                }
                else
                {
                    continue;
                }

            }
            while (!esNumero2);
            Console.WriteLine($"Ingresaste este numero: {Numero2} ");

            Console.WriteLine("Que operacion Quiere Realizar:");
            Console.WriteLine("1: Sumar");
            Console.WriteLine("2: Restar");
            Console.WriteLine("3: Multiplicar");
            Console.WriteLine("4: Dividir");
            int Valor = Convert.ToInt32(Console.ReadLine());

            switch (Valor)
            {
                case 1:
                    int resultado = Calculadora.OperacionSuma(Numero1, Numero2);
                    Console.WriteLine($"El resultado de la operacion es {resultado}");
                    Console.ReadLine();
                    break;

                case 2:
                    int resultado1 = Calculadora.OperacionResta(Numero1, Numero2);
                    Console.WriteLine($"El resultado de la operacion es {resultado1}");
                    Console.ReadLine();
                    break;

                case 3:
                    int resultado2 = Calculadora.OperacionMultiplicar(Numero1, Numero2);
                    Console.WriteLine($"El resultado de la operacion es {resultado2}");
                    Console.ReadLine();
                    break;

                case 4:

                    if (Numero2 == 0)
                    {
                        do
                        {
                            Logic.ErrorDivision(Numero1, Numero2);
                            Console.WriteLine("Error intentaste Dividir por 0 solo Chuck Norris divide por 0, vuelve a ingresar otro numero");
                            c = Console.ReadLine();
                            esNumero3 = int.TryParse(c, out Numero3);
                            if (esNumero3 == false)
                            {
                                Console.WriteLine("Error!!! seguro ingreso una letra o nada, debe ingrese un numero");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        while (!esNumero3);
                        Console.WriteLine($"Ingresaste este numero: {Numero3}");
                        int resultado3 = Calculadora.OperacionDividir(Numero1, Numero3);
                        Console.WriteLine($"El resultado de la operacion es {resultado3}");
                    }
                        
                    else
                    {
                        int resultado4 = Calculadora.OperacionDividir(Numero1, Numero2);
                        Console.WriteLine($"El resultado de la operacion es {resultado4}");
                    }

                    Console.WriteLine();
                    Console.ReadLine();
                    break;

            }
        }
    }
}
      
            
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class Logic
    {
        
        public static void ErrorDivision(int i, int j)
        {
            try 
            {
                int resultado = Calculadora.OperacionDividir(i, j);
                Console.WriteLine(resultado);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.Message);
                
            }

            finally
            {
                Console.WriteLine("");
            }
        }

        


    }
}

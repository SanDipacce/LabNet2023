using Microsoft.VisualStudio.TestTools.UnitTesting;
using labNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        public void OperacionSumaTest()
        {
            int i = 1;
            int j = 2;
            int resultadoObtenido = 0;
            int Resultado = 3;
            Calculadora calculadora = new Calculadora();

            resultadoObtenido = Calculadora.OperacionSuma(i, j);

            Assert.AreEqual(Resultado, resultadoObtenido);

        }

        [TestMethod()]
        public void OperacionRestaTest()
        {
            int i = 3;
            int j = 2;
            int resultadoObtenido = 0;
            int Resultado = 1;
            Calculadora calculadora = new Calculadora();

            resultadoObtenido = Calculadora.OperacionResta(i, j);

            Assert.AreEqual(Resultado, resultadoObtenido);

        }

        [TestMethod()]
        public void OperacionMultiplicarTest()
        {
            int i = 3;
            int j = 2;
            int resultadoObtenido = 0;
            int Resultado = 6;
            Calculadora calculadora = new Calculadora();

            resultadoObtenido = Calculadora.OperacionMultiplicar(i, j);

            Assert.AreEqual(Resultado, resultadoObtenido);

        }

        [TestMethod()]
        public void OperacionDividirTest()
        {
            int i = 6;
            int j = 2;
            int resultadoObtenido = 0;
            int Resultado = 3;
            Calculadora calculadora = new Calculadora();

            resultadoObtenido = Calculadora.OperacionDividir(i, j);

            Assert.AreEqual(Resultado, resultadoObtenido);

        }
    }
}
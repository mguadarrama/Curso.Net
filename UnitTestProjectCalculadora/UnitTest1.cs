using System.Runtime.CompilerServices;
using CalculadoraLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        CalculadoraMachine calculadora = new CalculadoraMachine();

        [TestMethod]
        public void TestMethod_Suma2y2()
        {
            int result  = calculadora.FuncionSumar(2, 3);
            Assert.AreEqual(5 , result);
        }
        [TestMethod]
        public void TestMethod_Multiplicar2y3()
        {
            int result = calculadora.FuncionMultiplicar(2, 3);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod_Restar2y3()
        {
            int result = calculadora.FuncionRestar(2, 3);
            Assert.AreEqual(1, result);
        }
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class09_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Calculadora : IContratoSumar
    {
        public int Sumatorio(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
    }

    class ClaseFinal : CalculadoraBase , IContratoSumar
    {
        public int Sumatorio(int valor1, int valor2)
        {
            throw new NotImplementedException();
        }


        public override int Multiplicador(int valor1, int valor2)
        {
            throw new NotImplementedException();
        }
    }

    class ClaseBase
    {
        private int Dividir(int valor1, int valor2)
        {
            return valor1/valor2;
        }
    }
    interface IContratoSumar
    {
        int Sumatorio(int valor1, int valor2);
    }
    
    /// <summary>
    /// Abstract Class
    /// http://msdn.microsoft.com/es-es/library/sf985hc5(v=vs.80).aspx
    /// </summary>
    abstract class CalculadoraBase
    {
        public abstract int Multiplicador(int valor1, int valor2);
        private int Restador(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
    }

}

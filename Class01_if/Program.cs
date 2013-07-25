using System;

namespace Class01_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el if");
            Console.WriteLine("Hola,");

            string resultado = Console.ReadLine();


            if (resultado == "Hola")
            {
                Console.WriteLine("Como Estas?");
            }
            else if (resultado == "Adios")
            {
                Console.WriteLine("Hasta Luego");
            }
            else
            {
                Console.WriteLine("Saluda primero, no?");
            }


            Console.WriteLine("Probando el switch");
            resultado = Console.ReadLine();

            switch (resultado)
            {
                case "Hola":
                    Console.WriteLine("Como Estas?");
                    break;
                case "Adios":
                    Console.WriteLine("Hasta Luego");
                    break;
                default:
                    Console.WriteLine("Saluda primero, no?");
                    break;
            }

        }
    }
}

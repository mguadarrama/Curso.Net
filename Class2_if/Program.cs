using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, soys unos pedazos de LOL's");

            string resultado = Console.ReadLine();



            //if (resultado == "Hola")
            //{
            //    Console.WriteLine("Como Estas?");
            //}
            //else if (resultado == "Adios")
            //{
            //    Console.WriteLine("Hasta Luego");
            //}
            //else
            //{
            //    Console.WriteLine("Saluda primero, no?");
            //}

            //switch (resultado)
            //{
            //    case "Hola" :
            //        Console.WriteLine("Como Estas?");
            //        break;
            //    case "Adios":
            //        Console.WriteLine("Hasta Luego");
            //        break;
            //    default :
            //        Console.WriteLine("Saluda primero, no?");
            //        break;
            //}

            //int e = 0;
            //while (e <= 5)
            //{
            //    Console.WriteLine("e = " + e);
            //    //e = e + 1;
            //    e++;
            //}








            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("i = {0}", i );
            //}



            //int[] numeros = {1, 2, 3, 4, 5};
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine("Que numero " +
            //                      "estoy " +
            //                      "leyendo " +
            //                      "ahora?????: " +
            //                      "{0}",numero);
            //}

            List<Cliente> clientes = new List<Cliente>();
          
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("Estoy leyendo " +
                                  "el cliente:{0}" + cliente);
            }



            Console.ReadKey();
        }
    }

    public class Cliente
    {
        public string nombre;
        public int edad;
    }
}

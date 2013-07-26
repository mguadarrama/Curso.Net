using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando loops");
            
            Console.WriteLine("Probando loops");
            
            int e = 0;
            while (e <= 5)
            {
                Console.WriteLine("e = " + e);
                //e = e + 1;
                e++;
            }


            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("i = {0}", i);
            }



            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach (int numero in numeros)
            {
                Console.WriteLine("Que numero " +
                                  "estoy " +
                                  "leyendo " +
                                  "ahora?????: " +
                                  "{0}", numero);
            }



        }
    }
}

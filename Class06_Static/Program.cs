using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class06_Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);


            Tiempo nuevoTiempo = new Tiempo();

            //Console.WriteLine(nuevoTiempo.DameLaFechaHora());
            Console.WriteLine(Tiempo.DameLaFechaHora());

            Console.ReadLine();

        }
    }

    class Tiempo
    {
        public static DateTime DameLaFechaHora()
        {
            return DateTime.Now;
        }

    }



}

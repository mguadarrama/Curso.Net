using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;

            


            try
            {
                sr = File.OpenText(@"c:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Linea Final");
            }

            Console.ReadKey();
        }
    }
}

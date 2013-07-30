using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente nCliente = new Cliente();
            string nombre = nCliente.Nombre;// Nombre es heredado de Persona

        }
    }

    


    class Cliente : Persona
    {
         
    }

    class Persona
    {
        public string Nombre;
    }





}

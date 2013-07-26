using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Class04_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente clienteGerman = new Cliente("German","Gomez");
            string resultado=""; //= clienteGerman.NombreCompleto();


            //Console.WriteLine(resultado);
            //Console.ReadKey();







            Cliente clienteBenja = new Cliente("Benja", "Zamora");
            Console.WriteLine(clienteBenja.Nombre);
            Console.WriteLine(clienteBenja.NombreCompleto());

            clienteBenja.Nombre = "NuevoNombre";
            clienteBenja.Apellido = "NuevoApellido";
            Console.WriteLine(clienteBenja.NombreCompleto());




            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }

}



namespace BusinessEntities
{
    class Cliente
    {
        // Variables privadas
        private string _nombre;
        private string _apellido;
        // Esto son propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        // Constructor sin parametros
        public Cliente()
        {
            
        }
        // Sobrecarga del constructor con 2 parametros
        public Cliente(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }
        // Metodo publico que retorna string
        
        public string NombreCompleto()
        {
            return _nombre + " " + _apellido;         
        }


    }


}
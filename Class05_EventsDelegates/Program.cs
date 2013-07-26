using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Class05_EventsDelegates
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteBenja = new Cliente("Benja", "Zamora");
            clienteBenja.CambioElNombre += new EventHandler(Cliente_CambioElNombre);
            clienteBenja.CambioElNombre += new EventHandler(Cliente_CambioElNombre2);

         
            clienteBenja.Nombre = "NuevoNombre";
            clienteBenja.Apellido = "NuevoApellido";
            Console.WriteLine(clienteBenja.NombreCompleto());



        }
        private static void Cliente_CambioElNombre2(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("He manejado el evento!");
        }
        private static void Cliente_CambioElNombre(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("He manejado el evento!");
        }
    }
}




namespace BusinessEntities
{
    class Cliente
    {
        //Eventos
        public event EventHandler CambioElNombre;
        // Variables privadas
        private string _nombre;
        private string _apellido;
        // Esto son propiedades
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                CambioElNombre(this, EventArgs.Empty);
                
            }
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
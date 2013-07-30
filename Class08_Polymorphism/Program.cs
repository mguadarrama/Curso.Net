using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clase Base
            DbConnection conexionBaseConnection = new SqlConnection();
            // Implementaciones concretas. Cada implementacon de dbConnection podría
            // tener un comportamiento distinto.
            SqlConnection sqlConnection = new SqlConnection();
            OleDbConnection oleDbConnection = new OleDbConnection();
            OdbcConnection odbcConnection = new OdbcConnection();
            

        }

       


    }
}

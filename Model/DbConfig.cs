using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace Mémoire_SI
{
    internal class DbConfig
    {
        // Mettre le chemin vers votre base de données SQL_SERVER
        private static string path = @"C:\Users\willc\Documents\si_db.mdf";





        //Ne pas toucher ce qui suit!
        private static string datasource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=";
        private static string secure = ";Integrated Security=True;Connect Timeout=30;Encrypt=True";
        
        public static SqlConnection con = new SqlConnection($"{datasource}{path}{secure}");

    }
}

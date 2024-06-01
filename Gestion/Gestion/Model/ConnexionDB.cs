using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*** include ***//
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Gestion.Model
{
    public class ConnexionDB
    {
        public static void testConnexion()
        {
            using (NpgsqlConnection connex = GetConnection())
            {
                try
                {
                    connex.Open();
                    if (connex.State == ConnectionState.Open)
                    {
                        string message = "Connexion of database has been stabled";

                        Console.WriteLine(message);
                        // MessageBox.Show(message);
                        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = "Erreur de connexion à la base de données : " + ex.Message;
                    Console.WriteLine(errorMessage);
                    MessageBox.Show(errorMessage, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=lionot;Database=gestion_personnel");
        }

        public static string GetConnectionString()
        {
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = "localhost";
            builder.Port = 5432;
            builder.Username = "postgres";
            builder.Password = "lionot";
            builder.Database = "gestion_personnel";

            return builder.ConnectionString;

        }
    }

}

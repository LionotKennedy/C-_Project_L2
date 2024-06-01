using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*** include ***//
using System.Windows.Forms;
using System.Data;

//*** include other folder ***//
using Gestion.Model;
using Npgsql;

namespace Gestion.Control
{
    public class ControlPointages
    {
        public int IdPointage { get; set; }
        public string numEmp_ref { get; set; }
        public string pointage { get; set; }
        public DateTime datePointage { get; set; }
       

        NpgsqlConnection connex = null;
        NpgsqlCommand commande = null;
        NpgsqlDataAdapter adapter = null;
        Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();

        DataTable dataTable = null;

        public DataTable SelectPointage()
        {
   
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();

            {
                connex = new NpgsqlConnection();
                connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();
                dataTable = new DataTable();
                try
                {
                    string request = "SELECT * FROM pointages";
                    commande = new NpgsqlCommand(request, connex);
                    adapter = new NpgsqlDataAdapter(commande);
                    connex.Open();
                    adapter.Fill(dataTable);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connex.Close();
                }
                return dataTable;
            }

        }

        //***** insert data *****//
        public bool InsertPointage(ControlPointages control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            //connection database//

            connex = new NpgsqlConnection();

            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();
            try
            {
                string request = "INSERT INTO pointages (numEmp_ref,pointage,datePointage) VALUES (@numEmp_ref,@pointage,@datePointage)";
                commande = new NpgsqlCommand(request, connex);
                // add parametre // 
                commande.Parameters.AddWithValue("@numEmp_ref", control.numEmp_ref);
                commande.Parameters.AddWithValue("@pointage", control.pointage);
                commande.Parameters.AddWithValue("@datePointage", control.datePointage);
                // connection open here //
                connex.Open();
                int rows = commande.ExecuteNonQuery();
                // if the query runs successfully then the value of rows will be greater than zero else its value will be 0//
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connex.Close();
            }
            return isSuccess;
        }
        //***** update data ****//
        public bool UpdatePointage(ControlPointages control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            // connexion database //
            connex = new NpgsqlConnection();

            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();

            try
            {
                string request = "UPDATE pointages SET numEmp_ref = @numEmp_ref, pointage = @pointage, datePointage = @datePointage WHERE IdPointage = @IdPointage";
                // create connexion //
                commande = new NpgsqlCommand(request, connex);

                // create parametre to add values // 
                commande.Parameters.AddWithValue("@IdPointage", control.IdPointage);
                commande.Parameters.AddWithValue("@numEmp_ref", control.numEmp_ref);
                commande.Parameters.AddWithValue("@pointage", control.pointage);
                commande.Parameters.AddWithValue("@datePointage", control.datePointage);
                // open connection here //
                connex.Open();
                int rows = commande.ExecuteNonQuery();
                // if the query runs successfully then the value of rows will be greater than zero else its value will be 0//
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connex.Close();
            }
            return isSuccess;
        }

        public bool Delete(ControlPointages control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            // connexion database //
            connex = new NpgsqlConnection();
            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();

            try
            {
                string request = "DELETE FROM pointages WHERE IdPointage = @IdPointage";
                // create connexion //
                commande = new NpgsqlCommand(request, connex);

                // create parametre to add values // 
                commande.Parameters.AddWithValue("@IdPointage", control.IdPointage);
                // open connection here //
                connex.Open();
                int rows = commande.ExecuteNonQuery();
                // if the query runs successfully then the value of rows will be greater than zero else its value will be 0//
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connex.Close();
            }
            return isSuccess;
        }
    }
}

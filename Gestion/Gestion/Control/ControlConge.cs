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
    public class ControlConge
    {
        public string numConge { get; set; }
        public string numEmp_ref { get; set; }
        public string motif { get; set; }
        public int nombreJour { get; set; }
        public DateTime dateDemande { get; set; }
        public DateTime dateRetour { get; set; }


        NpgsqlConnection connex = null;
        NpgsqlCommand commande = null;
        NpgsqlDataAdapter adapter = null;
        Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();

        DataTable dataTable = null;
        NpgsqlDataReader reader = null;

        public DataTable SelectConge()
        {

            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();

            {
                connex = new NpgsqlConnection();
                connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();
                dataTable = new DataTable();
                try
                {
                    string request = "SELECT * FROM conges";
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
        public bool InsertConge(ControlConge control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            //connection database//
            // connex = new SqlConnection();

            connex = new NpgsqlConnection();

            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();
            try
            {
                string request = "INSERT INTO conges (numConge,numEmp_ref,motif,nombreJour,dateDemande,dateRetour) VALUES (@numConge,@numEmp_ref,@motif,@nombreJour,@dateDemande,@dateRetour)";
                commande = new NpgsqlCommand(request, connex);
                // add parametre // 
                commande.Parameters.AddWithValue("@numConge", control.numConge);
                commande.Parameters.AddWithValue("@numEmp_ref", control.numEmp_ref);
                commande.Parameters.AddWithValue("@motif", control.motif);
                commande.Parameters.AddWithValue("@nombreJour", control.nombreJour);
                commande.Parameters.AddWithValue("@dateDemande", control.dateDemande);
                commande.Parameters.AddWithValue("@dateRetour", control.dateRetour);

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
        public bool UpdateConge(ControlConge control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            // connexion database //
            connex = new NpgsqlConnection();

            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();

            try
            {
                string request = "UPDATE conges SET numEmp_ref = @numEmp_ref, motif = @motif, nombreJour = @nombreJour, dateDemande = @dateDemande, dateRetour = @dateRetour WHERE numConge = @numConge";
                // create connexion //
                commande = new NpgsqlCommand(request, connex);

                // create parametre to add values //
                commande.Parameters.AddWithValue("@numConge", control.numConge);
                commande.Parameters.AddWithValue("@numEmp_ref", control.numEmp_ref);
                commande.Parameters.AddWithValue("@motif", control.motif);
                commande.Parameters.AddWithValue("@nombreJour", control.nombreJour);
                commande.Parameters.AddWithValue("@dateDemande", control.dateDemande);
                commande.Parameters.AddWithValue("@dateRetour", control.dateRetour);
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

        public bool DeleteConge(ControlConge control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            // connexion database //
            connex = new NpgsqlConnection();
            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();

            try
            {
                string request = "DELETE FROM conges WHERE numConge = @numConge";
                // create connexion //
                commande = new NpgsqlCommand(request, connex);

                // create parametre to add values // 
                commande.Parameters.AddWithValue("@numConge", control.numConge);
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

        public bool CongeExists(string numeroConge)
        {
            // Effectue la vérification dans la base de données pour vérifier si le numéro de congé existe déjà
            // Retourne true si le numéro de congé existe, sinon false
            // Tu devrais remplacer cette logique par ta propre logique de vérification dans ta base de données

            // Exemple de logique fictive
            // Si le numéro de congé existe déjà, retourne true
            // Sinon, retourne false
            if (numeroConge == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

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
    public class ControlEmployes
    {
        public string numEmp { get; set; }
        public string nomEmp { get; set; }
        public string prenomEmp { get; set; }
        public string post { get; set; }
        public int salaire { get; set; }


        //SqlConnection connex = null;
        //SqlCommand commande = null;
        //SqlDataAdapter adapter = null;

        NpgsqlConnection connex = null;
        NpgsqlCommand commande = null;
        NpgsqlDataAdapter adapter = null;
        Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();

        DataTable dataTable = null;
        NpgsqlDataReader reader = null;

        public DataTable Select()
        {
            //using (ConnexionDB connexionDB = GetConnexion())

            // ConnexionDB connexionDB = new ConnexionDB();


            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();

            {
                connex = new NpgsqlConnection();
                connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();
                dataTable = new DataTable();
                try
                {
                    string request = "SELECT * FROM employes";
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
        public bool Insert(ControlEmployes control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            //connection database//
            // connex = new SqlConnection();

            connex = new NpgsqlConnection();

            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();
            try
            {
                string request = "INSERT INTO employes (numEmp,nomEmp,prenomEmp,post,salaire) VALUES (@numEmp,@nomEmp,@prenomEmp,@post,@salaire)";
                commande = new NpgsqlCommand(request, connex);
                // add parametre // 
                commande.Parameters.AddWithValue("@numEmp", control.numEmp);
                commande.Parameters.AddWithValue("@nomEmp", control.nomEmp);
                commande.Parameters.AddWithValue("@prenomEmp", control.prenomEmp);
                commande.Parameters.AddWithValue("@post", control.post);
                commande.Parameters.AddWithValue("@salaire", control.salaire);
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
        public bool Update(ControlEmployes control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            // connexion database //
            connex = new NpgsqlConnection();

            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();

            try
            {
                string request = "UPDATE employes SET nomEmp = @nomEmp, prenomEmp = @prenomEmp, post = @post, salaire = @salaire WHERE numEmp = @numEmp";
                // create connexion //
                commande = new NpgsqlCommand(request, connex);

                // create parametre to add values // 
                commande.Parameters.AddWithValue("@numEmp", control.numEmp);
                commande.Parameters.AddWithValue("@nomEmp", control.nomEmp);
                commande.Parameters.AddWithValue("@prenomEmp", control.prenomEmp);
                commande.Parameters.AddWithValue("@post", control.post);
                commande.Parameters.AddWithValue("@salaire", control.salaire);
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

        public bool Delete(ControlEmployes control)
        {
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();
            bool isSuccess = false;
            // connexion database //
            connex = new NpgsqlConnection();
            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();

            try
            {
                string request = "DELETE FROM employes WHERE numEmp = @numEmp";
                // create connexion //
                commande = new NpgsqlCommand(request, connex);

                // create parametre to add values // 
                commande.Parameters.AddWithValue("@numEmp", control.numEmp);
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
        //recuperation donnee pour le combobox
        public NpgsqlDataReader ComboBox()
        {
            connex = new NpgsqlConnection();
            connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();      

            try
            {
                string Query = "SELECT numEmp FROM employes;";
                commande = new NpgsqlCommand(Query, connex);
                connex.Open();

                // On assigne le lecteur de données ici
                reader = commande.ExecuteReader(CommandBehavior.CloseConnection); // On utilise CommandBehavior.CloseConnection pour fermer automatiquement la connexion après la lecture
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // On ne ferme pas le lecteur de données ici, on le laisse ouvert

            return reader;
        }

        /**********************barre de recherche**********************/
        public DataTable Search()
        {
  
            Gestion.Model.ConnexionDB connexionDB = new Gestion.Model.ConnexionDB();

            {
                connex = new NpgsqlConnection();
                connex.ConnectionString = Gestion.Model.ConnexionDB.GetConnectionString();
                dataTable = new DataTable();
                try
                {
                    string request = "SELECT * FROM employes WHERE nomEmp LIKE '%" + @nomEmp + "%' OR prenomEmp LIKE '%" + @prenomEmp + "%' ";
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
    }
}

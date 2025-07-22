using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Vente_Billets.Classes
{
    class ClsDict
    {
        static ClsDict instance = null;

        public static ClsDict Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClsDict();
                return instance;
            }
        }

        SqlConnection con = null;
        SqlCommand cmd = null;
        private SqlDataAdapter dt;
        private SqlDataReader dr;

        public bool OpenConnection()
        {
            try
            {
                if (con == null)
                {
                    con = new SqlConnection(ClsConnexion.waybd);
                }

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
                return false;
            }
        }

        public void SaveUpdateClients(ClsClients cli)
        {
            string query = @"EXEC sp_SaveOrUpdateClient_Flexible @id, @noms, @adresse, @contact, @genre, @age";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", cli.Id);
                cmd.Parameters.AddWithValue("@noms", cli.Noms);
                cmd.Parameters.AddWithValue("@adresse", cli.Adresse);
                cmd.Parameters.AddWithValue("@contact", cli.Contact);
                cmd.Parameters.AddWithValue("@genre", cli.Genre);
                cmd.Parameters.AddWithValue("@age", cli.Age);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdateAgents(ClsAgents Ag)
        {
            string query = @"EXEC sp_SaveOrUpdateAgent_Flexible @id, @noms, @contact, @fonction, @username, @pwd, @refSalle";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", Ag.Id);
                cmd.Parameters.AddWithValue("@noms", Ag.Noms);
                cmd.Parameters.AddWithValue("@fonction", Ag.Fonction);
                cmd.Parameters.AddWithValue("@contact", Ag.Contact);
                cmd.Parameters.AddWithValue("@username", Ag.Username);
                cmd.Parameters.AddWithValue("@pwd", Ag.Password);
                cmd.Parameters.AddWithValue("@refSalle", Ag.RefSalle);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdateSalle(ClsSalle sa)
        {
            string query = @"EXEC SaveOrUpdateSalle @id, @nomSalle, @adresse, @nombrePlace";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", sa.Id);
                cmd.Parameters.AddWithValue("@nomSalle", sa.NomSalle);
                cmd.Parameters.AddWithValue("@adresse", sa.Adesse);
                cmd.Parameters.AddWithValue("@nombrePlace", sa.NombrePlace);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdateSpectacle(ClsSpectacle spect)
        {
            string query = @"EXEC SaveOrUpdateSpectacle @id, @titre, @dateSpectacle, @nombreBillet, @duree, @descriptionSpectacle, @refSalle";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", spect.Id);
                cmd.Parameters.AddWithValue("@titre", spect.Titre);
                cmd.Parameters.AddWithValue("@dateSpectacle", spect.DateSpectacle);
                cmd.Parameters.AddWithValue("@nombreBillet", spect.NombreBillet);
                cmd.Parameters.AddWithValue("@duree", spect.Duree);
                cmd.Parameters.AddWithValue("@descriptionSpectacle", spect.DescSpect);
                cmd.Parameters.AddWithValue("@refSalle", spect.RefSalle);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdatePlace(ClsPlace pl)
        {
            string query = @"EXEC SaveOrUpdatePlace @id, @typePlace, @numero, @refSalle";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", pl.Id);
                cmd.Parameters.AddWithValue("@typePlace", pl.TypePlace);
                cmd.Parameters.AddWithValue("@numero", pl.NumPlace);
                cmd.Parameters.AddWithValue("@refSalle", pl.RefSalle);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable loadData(string nomTable)
        {
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select * from " + nomTable + "", con);
            dt.Fill(table);
            con.Close();
            return table;
        }

        public void Deletedata(string nomTable, string champ_id, int id)
        {
            string query = $"DELETE FROM {nomTable} where {champ_id} = @id ";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

        }

        public void loadCombo(string nomTable, string nomchamp, System.Windows.Forms.ComboBox comb1)
        {
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("SELECT " + nomchamp + " FROM " + nomTable + "", con);
            try
            {
                DataTable dt1 = new DataTable();
                dt.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    comb1.Items.Add(dr[nomchamp]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }

            con.Close();
        }

        public string getcode_Combo(string nomTable, string nomChampId, string nomChamp, string valeur)
        {
            string IdData = "";
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select " + nomChampId + " from " + nomTable + " where " + nomChamp + "=@a", con);
                cmd.Parameters.AddWithValue("@a", valeur);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdData = (dr[nomChampId].ToString());
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return IdData;
        }


    }
}

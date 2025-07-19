using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vente_Billets.Classes;
using Vente_Billets.Formulaires;

namespace Vente_Billets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClsClients cl = new ClsClients();
        ClsAgents ag = new ClsAgents();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                panelClient.Visible = false;
                panelAgents.Visible = false;
                ChargementClient();
                ChargementAgent();
            }
            else
            {
                MessageBox.Show("Echec");
            }   
        }

        private void ChargementClient()
        {
            dgvClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClient.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvClient.GridColor = Color.Gray;
            dgvClient.DataSource = ClsDict.Instance.loadData("tClients");
            txtId.Visible = false;
            lblId.Visible = false;
            string[] genre = { "Feminin", "Masculin" };
            cmbGenre.Items.AddRange(genre);
        }

        private void ChargementAgent()
        {
            dgvAgents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAgents.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvAgents.GridColor = Color.Gray;
            dgvAgents.DataSource = ClsDict.Instance.loadData("tAgents");
            txtIdAgents.Visible = false;
            id.Visible = false;
            ClsDict.Instance.loadCombo("tSalle", "nomSalle", cmbSalleAgent);
        }

        private void CleanTextClient()
        {
            txtAdress.Text = "";
            txtContact.Text = "";
            cmbGenre.Text = "";
            txtNom.Text = "";
            NudAge.Value = 0;
            txtId.Visible = false;
            lblId.Visible = false;
        }

        private void CleanTextAgent()
        {
            txtContactAgent.Text = "";
            txtFoctionAgent.Text = "";
            cmbSalleAgent.Text = "";
            txtNomAgent.Text = "";
            txtUserNameAgent.Text = "";
            txtPasswordAgents.Text = "";
            txtIdAgents.Visible = false;
            id.Visible = false;
        }

        private void InsertUpdateClient(int a)
        {
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdress.Text;
            cl.Contact = txtContact.Text;
            cl.Age = (int)NudAge.Value;
            cl.Genre = cmbGenre.Text;

            if (a == 1)
            {
                cl.Id = 0;
                ClsDict.Instance.SaveUpdateClients(cl);
                dgvClient.DataSource = ClsDict.Instance.loadData("tClients");
            }
            else if (a == 2)
            {
                cl.Id = int.Parse(txtId.Text);
                ClsDict.Instance.SaveUpdateClients(cl);
                dgvClient.DataSource = ClsDict.Instance.loadData("tClients");
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tClients", "id", int.Parse(txtId.Text));
                dgvClient.DataSource = ClsDict.Instance.loadData("tClients");
            }
        }

        private void InsertUpdateAgent(int a)
        {
            ag.Noms = txtNomAgent.Text;
            ag.Contact = txtContactAgent.Text;
            ag.Fonction = txtFoctionAgent.Text;
            ag.Username = txtUserNameAgent.Text;
            ag.Password = txtPasswordAgents.Text;
            ag.RefSalle = ClsDict.Instance.getcode_Combo("tSalle", "id", "nomSalle", cmbSalleAgent.Text);

            if (a == 1)
            {
                ag.Id = 0;
                ClsDict.Instance.SaveUpdateAgents(ag);
                dgvAgents.DataSource = ClsDict.Instance.loadData("tAgents");
            }
            else if (a == 2)
            {
                ag.Id = int.Parse(txtIdAgents.Text);
                ClsDict.Instance.SaveUpdateAgents(ag);
                dgvAgents.DataSource = ClsDict.Instance.loadData("tAgents");
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tAgents", "id", int.Parse(txtIdAgents.Text));
                dgvAgents.DataSource = ClsDict.Instance.loadData("tAgents");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelClient.Visible = true;
            panelAgents.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(1);
        }

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(2);
            CleanTextClient();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(3);
            CleanTextClient();
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClient.Rows[e.RowIndex];

            txtId.Text = row.Cells["id"].Value.ToString(); // ID
            txtNom.Text = row.Cells["noms"].Value.ToString();
            txtAdress.Text = row.Cells["adresse"].Value.ToString();
            txtContact.Text = row.Cells["contact"].Value.ToString();
            NudAge.Text = row.Cells["age"].Value.ToString();
            cmbGenre.Text = row.Cells["genre"].Value.ToString();

            txtId.Visible = true;
            lblId.Visible = true;
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(2);
            CleanTextAgent();
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(3);
            CleanTextAgent();
        }

        private void dgvAgents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAgents.Rows[e.RowIndex];

            txtIdAgents.Text = row.Cells["id"].Value.ToString(); // ID
            txtNomAgent.Text = row.Cells["noms"].Value.ToString();
            txtContactAgent.Text = row.Cells["contact"].Value.ToString();
            txtFoctionAgent.Text = row.Cells["fonction"].Value.ToString();
            txtUserNameAgent.Text = row.Cells["username"].Value.ToString();
            txtPasswordAgents.Text = row.Cells["pwd"].Value.ToString();
            cmbSalleAgent.Text = row.Cells["refSalle"].Value.ToString();

            txtIdAgents.Visible = true;
            id.Visible = true;
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            panelAgents.Visible = true;
            panelClient.Visible = false;
        }
    }
}

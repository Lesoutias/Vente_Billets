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

namespace Vente_Billets.Formulaires
{
    public partial class FrmAgent : Form
    {
        public FrmAgent()
        {
            InitializeComponent();

        }

        
        private void dgvAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAgent_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsAgents.ChargementAgent(dgvAgents, txtIdAgents, id, cmbSalleAgent);
            }
        }

        ClsAgents ag = new ClsAgents();

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

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(1);
            CleanTextAgent();
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(2);
            CleanTextAgent();
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(2);
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
    }
}

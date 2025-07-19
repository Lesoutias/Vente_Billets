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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();

        }

        ClsClients cl = new ClsClients();

        private void InsertUpdateClient (int a)
        {
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdress.Text;
            cl.Contact = txtContact.Text;
            cl.Age = (int)NudAge.Value;
            cl.Genre = cmbGenre.Text;

            if(a == 1)
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
        private void frmClients_Load(object sender, EventArgs e)
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

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClient.Rows[e.RowIndex];

            txtId.Text = row.Cells["id"].Value.ToString(); // ID
            txtNom.Text = row.Cells["noms"].Value.ToString();
            txtAdress.Text = row.Cells["adresse"].Value.ToString();
            txtContact.Text = row.Cells["contact"].Value.ToString();
            NudAge.Text = row.Cells["age"].Value.ToString();

            txtId.Visible = true;
            lblId.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(1);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(2);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(3);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NudAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}

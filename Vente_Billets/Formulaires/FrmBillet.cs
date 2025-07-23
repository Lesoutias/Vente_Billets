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
    public partial class FrmBillet : Form
    {
        public FrmBillet()
        {
            InitializeComponent();
        }

        private void FrmBillet_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
                ClsDict.Instance.loadCombo("tSpectacle", "titre", cmbSpectacle);
                ClsDict.Instance.loadCombo("tPlace", "typePlace", cmbPlace);
                ClsDict.Instance.loadCombo("tClients", "noms", cmbClient);
                ClsDict.Instance.loadCombo("tAgents", "noms", cmbAgent);
                ClsDict.Instance.loadCombo("Facture", "id", cmbFacture);

            }
        }

        ClsBillets bi = new ClsBillets();

        private void InsertUpdateBillet (int a)
        {
            bi.Prix = double.Parse(txtPrix.Text);
            bi.DateAchat = DateTime.Parse(DateAchat.Text);
            bi.RefAgent1 = int.Parse(ClsDict.Instance.getcode_Combo("tAgents", "id", "noms", cmbAgent.Text));
            bi.RefClient1 = int.Parse(ClsDict.Instance.getcode_Combo("tClients", "id", "noms", cmbClient.Text));
            bi.RefPlace1 = int.Parse(ClsDict.Instance.getcode_Combo("tPlace", "id", "typePlace", cmbPlace.Text));
            bi.RefSpectacle1 = int.Parse(ClsDict.Instance.getcode_Combo("tSpectacle", "id", "titre", cmbSpectacle.Text));
            bi.RefFacture = int.Parse(ClsDict.Instance.getcode_Combo("Facture", "id", "id", cmbFacture.Text));


            if (a == 1)
            {
                bi.Id = 0;
                ClsDict.Instance.SaveUpdateBillet(bi);
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }

            else if (a == 2)
            {
                bi.Id = int.Parse(txtIdBillet.Text);
                ClsDict.Instance.SaveUpdateBillet(bi);
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }

            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tBillet", "id", int.Parse(txtIdBillet.Text));
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(2);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(3);
        }

        private void dgvBillet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBillet.Rows[e.RowIndex];

            txtIdBillet.Text = row.Cells["id"].Value.ToString(); // ID
            DateAchat.Text = row.Cells["dateAchat"].Value.ToString();
            txtPrix.Text = row.Cells["prix"].Value.ToString();
            string idSpectacle = row.Cells["refSpectacle"].Value.ToString();
            string idPlace= row.Cells["refPlace"].Value.ToString();
            string idAgent = row.Cells["refAgent"].Value.ToString();
            string idClient = row.Cells["refClient"].Value.ToString();
            string idFacture = row.Cells["refFacture"].Value.ToString();
            cmbSpectacle.Text = ClsDict.Instance.GetNomDepuisId("tSpectacle", "id", "titre", idSpectacle);
            cmbPlace.Text = ClsDict.Instance.GetNomDepuisId("tPlace", "id", "typePlace", idPlace);
            cmbAgent.Text = ClsDict.Instance.GetNomDepuisId("tAgents", "id", "noms", idAgent);
            cmbClient.Text = ClsDict.Instance.GetNomDepuisId("tClients", "id", "noms", idClient);
            cmbFacture.Text = ClsDict.Instance.GetNomDepuisId("Facture", "id", "id", idFacture);

            txtIdBillet.Visible = true;
            id.Visible = true;
        }

        private void txtIdBillet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

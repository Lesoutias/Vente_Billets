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
    public partial class FrmSpectacle : Form
    {
        public FrmSpectacle()
        {
            InitializeComponent();
        }

        private void FrmSpectacle_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
            
        }

        ClsSpectacle spect = new ClsSpectacle();

        private void InsertUpdateSpectacle(int a)
        {
            spect.Titre = txtTitre.Text;
            spect.DateSpectacle = DateTime.Parse(DateSpectacle.Text);
            spect.NombreBillet = int.Parse(txtNbrBillet.Text);
            spect.Duree = txtDuree.Text;
            spect.DescSpect = txtDescSpect.Text;
            spect.RefSalle = int.Parse(ClsDict.Instance.getcode_Combo("tSalle", "id", "nomSalle", cmbSpectacle.Text));
            if (a == 1)
            {
                spect.Id = 0;
                ClsDict.Instance.SaveUpdateSpectacle(spect);
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
            else if (a == 2)
            {
                spect.Id = int.Parse(txtIdSpectacle.Text);
                ClsDict.Instance.SaveUpdateSpectacle(spect);
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tSpectacle", "id", int.Parse(txtIdSpectacle.Text));
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSpectacle(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSpectacle(2);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSpectacle(3);
        }

        private void dgvSpectacle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSpectacle.Rows[e.RowIndex];

            txtIdSpectacle.Text = row.Cells["id"].Value.ToString(); // ID
            DateSpectacle.Text = row.Cells["dateSpectacle"].Value.ToString();
            txtNbrBillet.Text = row.Cells["nombreBillet"].Value.ToString();
            txtDuree.Text = row.Cells["duree"].Value.ToString();
            txtDescSpect.Text = row.Cells["descriptionSpectacle"].Value.ToString();
            cmbSpectacle.SelectedValue = row.Cells["refSalle"].Value;
            txtTitre.Text = row.Cells["titre"].Value.ToString();

            txtIdSpectacle.Visible = true;
            lblId.Visible = true;
        }
    }
}

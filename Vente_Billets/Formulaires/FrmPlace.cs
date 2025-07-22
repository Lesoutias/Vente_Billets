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
    public partial class FrmPlace : Form
    {
        public FrmPlace()
        {
            InitializeComponent();
        }

        private void FrmPlace_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
            }
            
        }

        ClsPlace pl = new ClsPlace();
        private void InsertUpdatePlace(int a)
        {
            pl.TypePlace = txtTypePlace.Text;
            pl.NumPlace = txtNumPlace.Text;
            pl.RefSalle = int.Parse(ClsDict.Instance.getcode_Combo("tSalle", "id", "nomSalle", cmbSallePlace.Text));

            if (a == 1)
            {
                pl.Id = 0;
                ClsDict.Instance.SaveUpdatePlace(pl);
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
            }
            else if (a == 2)
            {
                pl.Id = int.Parse(txtIdPlace.Text);
                ClsDict.Instance.SaveUpdatePlace(pl);
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tPlace", "id", int.Parse(txtIdPlace.Text));
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdatePlace(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdatePlace(2);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdatePlace(3);
        }

        private void dgvPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPlace.Rows[e.RowIndex];

            txtIdPlace.Text = row.Cells["id"].Value.ToString(); // ID
            txtTypePlace.Text = row.Cells["typePlace"].Value.ToString();
            txtNumPlace.Text = row.Cells["numero"].Value.ToString();
            cmbSallePlace.SelectedValue = row.Cells["refSalle"].Value;

            txtIdPlace.Visible = true;
            id.Visible = true;
        }
    }
}

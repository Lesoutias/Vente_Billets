using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vente_Billets.Classes
{
    class ClsPlace
    {
        int id;
        string typePlace;
        string numPlace;
        int refSalle;

        public int Id { get => id; set => id = value; }
        public string TypePlace { get => typePlace; set => typePlace = value; }
        public string NumPlace { get => numPlace; set => numPlace = value; }
        public int RefSalle { get => refSalle; set => refSalle = value; }

        public static void ChargementPlace(DataGridView dgv, Guna2TextBox txtId, Label lblId, ComboBox cmb)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.DataSource = ClsDict.Instance.loadData("tPlace");
            txtId.Visible = false;
            lblId.Visible = false;
            ClsDict.Instance.loadCombo("tSalle", "nomSalle", cmb);
        }
    }
}

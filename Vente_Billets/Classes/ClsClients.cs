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
    class ClsClients
    {
        int id;
        string noms;
        string adresse;
        string contact;
        string genre;
        int age;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Age { get => age; set => age = value; }

        public static void ChargementClient(DataGridView dgv, Guna2TextBox txtId, Label lblId, ComboBox cmb)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.DataSource = ClsDict.Instance.loadData("tClients");
            txtId.Visible = false;
            lblId.Visible = false;
            string[] genre = { "Feminin", "Masculin" };
            cmb.Items.AddRange(genre);
        }
    }
}

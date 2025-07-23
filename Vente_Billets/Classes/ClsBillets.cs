﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vente_Billets.Classes
{
    class ClsBillets
    {
        int id;
        DateTime dateAchat;
        double prix;
        bool statut = false;
        int RefClient;
        int RefAgent;
        int RefPlace;
        int RefSpectacle;
        int refFacture;

        public int Id { get => id; set => id = value; }
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
        public double Prix { get => prix; set => prix = value; }
        public int RefClient1 { get => RefClient; set => RefClient = value; }
        public int RefAgent1 { get => RefAgent; set => RefAgent = value; }
        public int RefPlace1 { get => RefPlace; set => RefPlace = value; }
        public int RefSpectacle1 { get => RefSpectacle; set => RefSpectacle = value; }
        public bool Statut { get => statut; set => statut = value; }
        public int RefFacture { get => refFacture; set => refFacture = value; }

        public static void ChargementBillets(DataGridView dgv, Guna2TextBox txtId, Label lblId)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DataSource = ClsDict.Instance.loadData("Affichez_Billet");
            txtId.Visible = false;
            lblId.Visible = false;
            
        }
    }
}

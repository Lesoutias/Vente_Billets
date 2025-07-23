
namespace Vente_Billets.Formulaires
{
    partial class FrmFacture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbPlace = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeleteAgent = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAgent = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouterAgent = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdfacture = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dgvFacture = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPlace
            // 
            this.cmbPlace.BackColor = System.Drawing.Color.Transparent;
            this.cmbPlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPlace.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPlace.ItemHeight = 30;
            this.cmbPlace.Location = new System.Drawing.Point(1029, 127);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(250, 36);
            this.cmbPlace.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(935, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 126;
            this.label1.Text = "Place";
            // 
            // BtnDeleteAgent
            // 
            this.BtnDeleteAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteAgent.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAgent.Location = new System.Drawing.Point(870, 602);
            this.BtnDeleteAgent.Name = "BtnDeleteAgent";
            this.BtnDeleteAgent.Size = new System.Drawing.Size(180, 45);
            this.BtnDeleteAgent.TabIndex = 124;
            this.BtnDeleteAgent.Text = "Delete";
            this.BtnDeleteAgent.Click += new System.EventHandler(this.BtnDeleteAgent_Click);
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateAgent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAgent.Location = new System.Drawing.Point(552, 602);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateAgent.TabIndex = 123;
            this.btnUpdateAgent.Text = "Update";
            this.btnUpdateAgent.Click += new System.EventHandler(this.btnUpdateAgent_Click);
            // 
            // BtnAjouterAgent
            // 
            this.BtnAjouterAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAjouterAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAjouterAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAjouterAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAjouterAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjouterAgent.ForeColor = System.Drawing.Color.White;
            this.BtnAjouterAgent.Location = new System.Drawing.Point(243, 602);
            this.BtnAjouterAgent.Name = "BtnAjouterAgent";
            this.BtnAjouterAgent.Size = new System.Drawing.Size(180, 45);
            this.BtnAjouterAgent.TabIndex = 122;
            this.BtnAjouterAgent.Text = "Ajouter";
            this.BtnAjouterAgent.Click += new System.EventHandler(this.BtnAjouterAgent_Click);
            // 
            // txtIdfacture
            // 
            this.txtIdfacture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdfacture.DefaultText = "";
            this.txtIdfacture.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdfacture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdfacture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdfacture.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdfacture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdfacture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdfacture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdfacture.Location = new System.Drawing.Point(118, 212);
            this.txtIdfacture.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtIdfacture.Name = "txtIdfacture";
            this.txtIdfacture.PlaceholderText = "";
            this.txtIdfacture.SelectedText = "";
            this.txtIdfacture.Size = new System.Drawing.Size(267, 38);
            this.txtIdfacture.TabIndex = 121;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(14, 232);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 20);
            this.id.TabIndex = 120;
            this.id.Text = "id";
            // 
            // dgvFacture
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFacture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacture.ColumnHeadersHeight = 4;
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacture.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacture.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFacture.Location = new System.Drawing.Point(104, 292);
            this.dgvFacture.Name = "dgvFacture";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacture.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFacture.RowHeadersVisible = false;
            this.dgvFacture.RowHeadersWidth = 62;
            this.dgvFacture.RowTemplate.Height = 28;
            this.dgvFacture.Size = new System.Drawing.Size(1108, 276);
            this.dgvFacture.TabIndex = 119;
            this.dgvFacture.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFacture.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFacture.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFacture.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFacture.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFacture.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFacture.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFacture.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFacture.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFacture.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFacture.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFacture.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFacture.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvFacture.ThemeStyle.ReadOnly = false;
            this.dgvFacture.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFacture.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacture.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFacture.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFacture.ThemeStyle.RowsStyle.Height = 28;
            this.dgvFacture.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFacture.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFacture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacture_CellClick);
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.Color.Transparent;
            this.cmbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbClient.ItemHeight = 30;
            this.cmbClient.Location = new System.Drawing.Point(117, 132);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(266, 36);
            this.cmbClient.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(931, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 117;
            this.label11.Text = "Agent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 110;
            this.label8.Text = "Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(171, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(858, 70);
            this.label7.TabIndex = 109;
            this.label7.Text = "ENREGISTREMENT DES FACTURES";
            // 
            // cmbAgent
            // 
            this.cmbAgent.BackColor = System.Drawing.Color.Transparent;
            this.cmbAgent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAgent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAgent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAgent.ItemHeight = 30;
            this.cmbAgent.Location = new System.Drawing.Point(1025, 203);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(250, 36);
            this.cmbAgent.TabIndex = 132;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Vente_Billets.Properties.Resources.facture;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1312, 151);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(450, 417);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 131;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1170, 602);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 133;
            this.guna2Button1.Text = "Imprimer";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FrmFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 692);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeleteAgent);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.BtnAjouterAgent);
            this.Controls.Add(this.txtIdfacture);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFacture";
            this.Text = "FrmFacture";
            this.Load += new System.EventHandler(this.FrmFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbPlace;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteAgent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAgent;
        private Guna.UI2.WinForms.Guna2Button BtnAjouterAgent;
        private Guna.UI2.WinForms.Guna2TextBox txtIdfacture;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFacture;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAgent;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
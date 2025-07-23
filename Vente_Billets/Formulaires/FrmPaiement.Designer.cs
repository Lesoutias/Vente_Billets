
namespace Vente_Billets.Formulaires
{
    partial class FrmPaiement
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
            this.DatePaie = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnDeleteAgent = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAgent = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouterAgent = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdPaiement = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dgvPaiement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModePaie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePaie
            // 
            this.DatePaie.BackColor = System.Drawing.Color.White;
            this.DatePaie.Checked = true;
            this.DatePaie.FillColor = System.Drawing.Color.White;
            this.DatePaie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePaie.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePaie.Location = new System.Drawing.Point(104, 133);
            this.DatePaie.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePaie.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePaie.Name = "DatePaie";
            this.DatePaie.Size = new System.Drawing.Size(179, 26);
            this.DatePaie.TabIndex = 104;
            this.DatePaie.Value = new System.DateTime(2025, 7, 21, 4, 51, 15, 315);
            // 
            // BtnDeleteAgent
            // 
            this.BtnDeleteAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteAgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteAgent.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAgent.Location = new System.Drawing.Point(581, 391);
            this.BtnDeleteAgent.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteAgent.Name = "BtnDeleteAgent";
            this.BtnDeleteAgent.Size = new System.Drawing.Size(120, 29);
            this.BtnDeleteAgent.TabIndex = 103;
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
            this.btnUpdateAgent.Location = new System.Drawing.Point(369, 391);
            this.btnUpdateAgent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(120, 29);
            this.btnUpdateAgent.TabIndex = 102;
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
            this.BtnAjouterAgent.Location = new System.Drawing.Point(163, 391);
            this.BtnAjouterAgent.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAjouterAgent.Name = "BtnAjouterAgent";
            this.BtnAjouterAgent.Size = new System.Drawing.Size(120, 29);
            this.BtnAjouterAgent.TabIndex = 101;
            this.BtnAjouterAgent.Text = "Ajouter";
            this.BtnAjouterAgent.Click += new System.EventHandler(this.BtnAjouterAgent_Click);
            // 
            // txtIdPaiement
            // 
            this.txtIdPaiement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPaiement.DefaultText = "";
            this.txtIdPaiement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPaiement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPaiement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPaiement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPaiement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPaiement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPaiement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPaiement.Location = new System.Drawing.Point(105, 177);
            this.txtIdPaiement.Name = "txtIdPaiement";
            this.txtIdPaiement.PlaceholderText = "";
            this.txtIdPaiement.SelectedText = "";
            this.txtIdPaiement.Size = new System.Drawing.Size(178, 25);
            this.txtIdPaiement.TabIndex = 100;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(10, 189);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 20);
            this.id.TabIndex = 99;
            this.id.Text = "id";
            // 
            // dgvPaiement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPaiement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaiement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaiement.ColumnHeadersHeight = 4;
            this.dgvPaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaiement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaiement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaiement.Location = new System.Drawing.Point(86, 221);
            this.dgvPaiement.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPaiement.Name = "dgvPaiement";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaiement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaiement.RowHeadersVisible = false;
            this.dgvPaiement.RowHeadersWidth = 62;
            this.dgvPaiement.RowTemplate.Height = 28;
            this.dgvPaiement.Size = new System.Drawing.Size(739, 148);
            this.dgvPaiement.TabIndex = 98;
            this.dgvPaiement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaiement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPaiement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPaiement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPaiement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPaiement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaiement.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaiement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPaiement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPaiement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPaiement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPaiement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPaiement.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPaiement.ThemeStyle.ReadOnly = false;
            this.dgvPaiement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaiement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaiement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPaiement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPaiement.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPaiement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaiement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPaiement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaiement_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 94;
            this.label12.Text = "Agent";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 145);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 93;
            this.label13.Text = "Date";
            // 
            // txtMontant
            // 
            this.txtMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontant.DefaultText = "";
            this.txtMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Location = new System.Drawing.Point(387, 97);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PlaceholderText = "";
            this.txtMontant.SelectedText = "";
            this.txtMontant.Size = new System.Drawing.Size(167, 25);
            this.txtMontant.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Montant";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Mode_Paiement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(612, 47);
            this.label7.TabIndex = 86;
            this.label7.Text = "ENREGISTREMENT DES PAIEMENTS";
            // 
            // cmbModePaie
            // 
            this.cmbModePaie.BackColor = System.Drawing.Color.White;
            this.cmbModePaie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModePaie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModePaie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModePaie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModePaie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModePaie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbModePaie.ItemHeight = 30;
            this.cmbModePaie.Location = new System.Drawing.Point(105, 87);
            this.cmbModePaie.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModePaie.Name = "cmbModePaie";
            this.cmbModePaie.Size = new System.Drawing.Size(178, 36);
            this.cmbModePaie.TabIndex = 107;
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
            this.cmbAgent.Location = new System.Drawing.Point(386, 145);
            this.cmbAgent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(168, 36);
            this.cmbAgent.TabIndex = 108;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Vente_Billets.Properties.Resources.paiement;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(820, 40);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 380);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 109;
            this.guna2PictureBox1.TabStop = false;
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
            this.cmbClient.Location = new System.Drawing.Point(657, 93);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(168, 36);
            this.cmbClient.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Client";
            // 
            // FrmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.cmbModePaie);
            this.Controls.Add(this.DatePaie);
            this.Controls.Add(this.BtnDeleteAgent);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.BtnAjouterAgent);
            this.Controls.Add(this.txtIdPaiement);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgvPaiement);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "FrmPaiement";
            this.Text = "FrmPaiement";
            this.Load += new System.EventHandler(this.FrmPaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePaie;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteAgent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAgent;
        private Guna.UI2.WinForms.Guna2Button BtnAjouterAgent;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPaiement;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPaiement;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtMontant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModePaie;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAgent;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        private System.Windows.Forms.Label label1;
    }
}
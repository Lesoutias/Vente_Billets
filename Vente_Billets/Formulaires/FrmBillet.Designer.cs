
namespace Vente_Billets.Formulaires
{
    partial class FrmBillet
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DateAchat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnDeleteAgent = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAgent = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouterAgent = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdBillet = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dgvBillet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrix = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSpectacle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPlace = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFacture = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Place";
            // 
            // DateAchat
            // 
            this.DateAchat.BackColor = System.Drawing.Color.White;
            this.DateAchat.Checked = true;
            this.DateAchat.FillColor = System.Drawing.Color.White;
            this.DateAchat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateAchat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateAchat.Location = new System.Drawing.Point(117, 203);
            this.DateAchat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateAchat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateAchat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateAchat.Name = "DateAchat";
            this.DateAchat.Size = new System.Drawing.Size(268, 40);
            this.DateAchat.TabIndex = 104;
            this.DateAchat.Value = new System.DateTime(2025, 7, 21, 4, 51, 15, 315);
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
            this.btnUpdateAgent.Location = new System.Drawing.Point(552, 602);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(180, 45);
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
            this.BtnAjouterAgent.Location = new System.Drawing.Point(243, 602);
            this.BtnAjouterAgent.Name = "BtnAjouterAgent";
            this.BtnAjouterAgent.Size = new System.Drawing.Size(180, 45);
            this.BtnAjouterAgent.TabIndex = 101;
            this.BtnAjouterAgent.Text = "Ajouter";
            this.BtnAjouterAgent.Click += new System.EventHandler(this.BtnAjouterAgent_Click);
            // 
            // txtIdBillet
            // 
            this.txtIdBillet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBillet.DefaultText = "";
            this.txtIdBillet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdBillet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdBillet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBillet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBillet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBillet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdBillet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBillet.Location = new System.Drawing.Point(530, 271);
            this.txtIdBillet.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtIdBillet.Name = "txtIdBillet";
            this.txtIdBillet.PlaceholderText = "";
            this.txtIdBillet.SelectedText = "";
            this.txtIdBillet.Size = new System.Drawing.Size(267, 38);
            this.txtIdBillet.TabIndex = 100;
            this.txtIdBillet.TextChanged += new System.EventHandler(this.txtIdBillet_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(438, 289);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 20);
            this.id.TabIndex = 99;
            this.id.Text = "id";
            // 
            // dgvBillet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBillet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillet.ColumnHeadersHeight = 4;
            this.dgvBillet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillet.Location = new System.Drawing.Point(104, 340);
            this.dgvBillet.Name = "dgvBillet";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBillet.RowHeadersVisible = false;
            this.dgvBillet.RowHeadersWidth = 62;
            this.dgvBillet.RowTemplate.Height = 28;
            this.dgvBillet.Size = new System.Drawing.Size(1108, 228);
            this.dgvBillet.TabIndex = 98;
            this.dgvBillet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBillet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBillet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBillet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillet.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBillet.ThemeStyle.ReadOnly = false;
            this.dgvBillet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBillet.ThemeStyle.RowsStyle.Height = 28;
            this.dgvBillet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBillet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillet_CellClick);
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
            this.cmbAgent.Location = new System.Drawing.Point(1028, 206);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(250, 36);
            this.cmbAgent.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(934, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 96;
            this.label11.Text = "Agent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 94;
            this.label12.Text = "Spectacle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 93;
            this.label13.Text = "Date_Achat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(934, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Client";
            // 
            // txtPrix
            // 
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.DefaultText = "";
            this.txtPrix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrix.Location = new System.Drawing.Point(117, 149);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.PlaceholderText = "";
            this.txtPrix.SelectedText = "";
            this.txtPrix.Size = new System.Drawing.Size(268, 38);
            this.txtPrix.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Prix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(171, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(797, 70);
            this.label7.TabIndex = 86;
            this.label7.Text = "ENREGISTREMENT DES BILLETS";
            // 
            // cmbSpectacle
            // 
            this.cmbSpectacle.BackColor = System.Drawing.Color.Transparent;
            this.cmbSpectacle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpectacle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpectacle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpectacle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpectacle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSpectacle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSpectacle.ItemHeight = 30;
            this.cmbSpectacle.Location = new System.Drawing.Point(530, 142);
            this.cmbSpectacle.Name = "cmbSpectacle";
            this.cmbSpectacle.Size = new System.Drawing.Size(250, 36);
            this.cmbSpectacle.TabIndex = 106;
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
            this.cmbPlace.Location = new System.Drawing.Point(530, 206);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(250, 36);
            this.cmbPlace.TabIndex = 107;
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
            this.cmbClient.Location = new System.Drawing.Point(1028, 134);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(250, 36);
            this.cmbClient.TabIndex = 108;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Vente_Billets.Properties.Resources.ticket2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1287, 128);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(450, 440);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 109;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1667, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 111;
            this.label2.Text = "Num Facture";
            // 
            // cmbFacture
            // 
            this.cmbFacture.BackColor = System.Drawing.Color.Transparent;
            this.cmbFacture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacture.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFacture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFacture.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFacture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFacture.ItemHeight = 30;
            this.cmbFacture.Location = new System.Drawing.Point(117, 283);
            this.cmbFacture.Name = "cmbFacture";
            this.cmbFacture.Size = new System.Drawing.Size(250, 36);
            this.cmbFacture.TabIndex = 112;
            // 
            // FrmBillet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1724, 665);
            this.Controls.Add(this.cmbFacture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(this.cmbSpectacle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateAchat);
            this.Controls.Add(this.BtnDeleteAgent);
            this.Controls.Add(this.btnUpdateAgent);
            this.Controls.Add(this.BtnAjouterAgent);
            this.Controls.Add(this.txtIdBillet);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgvBillet);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBillet";
            this.Text = "FrmBillet";
            this.Load += new System.EventHandler(this.FrmBillet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateAchat;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteAgent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAgent;
        private Guna.UI2.WinForms.Guna2Button BtnAjouterAgent;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBillet;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillet;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAgent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtPrix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSpectacle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPlace;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFacture;
        private System.Windows.Forms.Label label2;
    }
}
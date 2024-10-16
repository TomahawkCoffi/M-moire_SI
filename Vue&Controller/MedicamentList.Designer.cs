namespace Mémoire_SI
{
    partial class MedicamentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicamentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnmedsupp = new Guna.UI2.WinForms.Guna2Button();
            this.btnmedmod = new Guna.UI2.WinForms.Guna2Button();
            this.medaddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.mednomtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.si_dbDataSet1 = new Mémoire_SI.si_dbDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new Mémoire_SI.si_dbDataSet1TableAdapters.categoryTableAdapter();
            this.medcatcb = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // medicamentDGV
            // 
            this.medicamentDGV.AllowUserToAddRows = false;
            this.medicamentDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.medicamentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.medicamentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicamentDGV.BackgroundColor = System.Drawing.Color.White;
            this.medicamentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicamentDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicamentDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.medicamentDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicamentDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.medicamentDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.medicamentDGV.EnableHeadersVisualStyles = false;
            this.medicamentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicamentDGV.Location = new System.Drawing.Point(0, 276);
            this.medicamentDGV.Name = "medicamentDGV";
            this.medicamentDGV.ReadOnly = true;
            this.medicamentDGV.RowHeadersVisible = false;
            this.medicamentDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.medicamentDGV.RowTemplate.Height = 28;
            this.medicamentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamentDGV.Size = new System.Drawing.Size(1285, 402);
            this.medicamentDGV.TabIndex = 25;
            this.medicamentDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.medicamentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.medicamentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medicamentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medicamentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medicamentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medicamentDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.medicamentDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicamentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medicamentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medicamentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.medicamentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medicamentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medicamentDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.medicamentDGV.ThemeStyle.ReadOnly = true;
            this.medicamentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.medicamentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicamentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicamentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicamentDGV.ThemeStyle.RowsStyle.Height = 28;
            this.medicamentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicamentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicamentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicamentDGV_CellContentClick);
            // 
            // btnmedsupp
            // 
            this.btnmedsupp.BorderRadius = 5;
            this.btnmedsupp.CheckedState.Parent = this.btnmedsupp;
            this.btnmedsupp.CustomImages.Parent = this.btnmedsupp;
            this.btnmedsupp.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnmedsupp.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedsupp.ForeColor = System.Drawing.Color.White;
            this.btnmedsupp.HoverState.Parent = this.btnmedsupp;
            this.btnmedsupp.Image = global::Mémoire_SI.Properties.Resources.icons8_supprimer_pour_toujours_50;
            this.btnmedsupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnmedsupp.Location = new System.Drawing.Point(931, 210);
            this.btnmedsupp.Name = "btnmedsupp";
            this.btnmedsupp.ShadowDecoration.Parent = this.btnmedsupp;
            this.btnmedsupp.Size = new System.Drawing.Size(244, 60);
            this.btnmedsupp.TabIndex = 24;
            this.btnmedsupp.Text = "SUPPRIMER";
            this.btnmedsupp.Click += new System.EventHandler(this.btnmedsupp_Click);
            // 
            // btnmedmod
            // 
            this.btnmedmod.BorderRadius = 5;
            this.btnmedmod.CheckedState.Parent = this.btnmedmod;
            this.btnmedmod.CustomImages.Parent = this.btnmedmod;
            this.btnmedmod.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnmedmod.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedmod.ForeColor = System.Drawing.Color.White;
            this.btnmedmod.HoverState.Parent = this.btnmedmod;
            this.btnmedmod.Image = global::Mémoire_SI.Properties.Resources.icons8_boucle_50;
            this.btnmedmod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnmedmod.Location = new System.Drawing.Point(488, 210);
            this.btnmedmod.Name = "btnmedmod";
            this.btnmedmod.ShadowDecoration.Parent = this.btnmedmod;
            this.btnmedmod.Size = new System.Drawing.Size(244, 60);
            this.btnmedmod.TabIndex = 23;
            this.btnmedmod.Text = "MODIFIER";
            this.btnmedmod.Click += new System.EventHandler(this.btnmedmod_Click);
            // 
            // medaddbtn
            // 
            this.medaddbtn.BorderRadius = 5;
            this.medaddbtn.CheckedState.Parent = this.medaddbtn;
            this.medaddbtn.CustomImages.Parent = this.medaddbtn;
            this.medaddbtn.FillColor = System.Drawing.Color.DarkOrchid;
            this.medaddbtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medaddbtn.ForeColor = System.Drawing.Color.White;
            this.medaddbtn.HoverState.Parent = this.medaddbtn;
            this.medaddbtn.Image = global::Mémoire_SI.Properties.Resources.icons8_approved_48;
            this.medaddbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.medaddbtn.Location = new System.Drawing.Point(68, 210);
            this.medaddbtn.Name = "medaddbtn";
            this.medaddbtn.ShadowDecoration.Parent = this.medaddbtn;
            this.medaddbtn.Size = new System.Drawing.Size(244, 60);
            this.medaddbtn.TabIndex = 22;
            this.medaddbtn.Text = "AJOUTER";
            this.medaddbtn.Click += new System.EventHandler(this.medaddbtn_Click);
            // 
            // mednomtb
            // 
            this.mednomtb.BackColor = System.Drawing.Color.White;
            this.mednomtb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mednomtb.Location = new System.Drawing.Point(68, 92);
            this.mednomtb.MaxLength = 100;
            this.mednomtb.Name = "mednomtb";
            this.mednomtb.Size = new System.Drawing.Size(460, 43);
            this.mednomtb.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nom Médicament";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.si_dbDataSet1;
            // 
            // si_dbDataSet1
            // 
            this.si_dbDataSet1.DataSetName = "si_dbDataSet1";
            this.si_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 41);
            this.label3.TabIndex = 27;
            this.label3.Text = "Type Médicament :";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // medcatcb
            // 
            this.medcatcb.BackColor = System.Drawing.Color.Transparent;
            this.medcatcb.BorderRadius = 5;
            this.medcatcb.DataSource = this.categoryBindingSource;
            this.medcatcb.DisplayMember = "Catnom";
            this.medcatcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.medcatcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medcatcb.FillColor = System.Drawing.Color.DarkOrchid;
            this.medcatcb.FocusedColor = System.Drawing.Color.Empty;
            this.medcatcb.FocusedState.Parent = this.medcatcb;
            this.medcatcb.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medcatcb.ForeColor = System.Drawing.Color.White;
            this.medcatcb.FormattingEnabled = true;
            this.medcatcb.HoverState.Parent = this.medcatcb;
            this.medcatcb.ItemHeight = 30;
            this.medcatcb.ItemsAppearance.Parent = this.medcatcb;
            this.medcatcb.Location = new System.Drawing.Point(823, 94);
            this.medcatcb.Name = "medcatcb";
            this.medcatcb.ShadowDecoration.Parent = this.medcatcb;
            this.medcatcb.Size = new System.Drawing.Size(329, 36);
            this.medcatcb.TabIndex = 28;
            this.medcatcb.ValueMember = "CId";
            this.medcatcb.SelectedIndexChanged += new System.EventHandler(this.medcatcb_SelectedIndexChanged_1);
            // 
            // MedicamentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 678);
            this.Controls.Add(this.medcatcb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medicamentDGV);
            this.Controls.Add(this.btnmedsupp);
            this.Controls.Add(this.btnmedmod);
            this.Controls.Add(this.medaddbtn);
            this.Controls.Add(this.mednomtb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicamentList";
            this.Text = "medicament";
            this.Load += new System.EventHandler(this.medicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView medicamentDGV;
        private Guna.UI2.WinForms.Guna2Button btnmedsupp;
        private Guna.UI2.WinForms.Guna2Button btnmedmod;
        private Guna.UI2.WinForms.Guna2Button medaddbtn;
        private System.Windows.Forms.TextBox mednomtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private si_dbDataSet1 si_dbDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private si_dbDataSet1TableAdapters.categoryTableAdapter categoryTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox medcatcb;
    }
}
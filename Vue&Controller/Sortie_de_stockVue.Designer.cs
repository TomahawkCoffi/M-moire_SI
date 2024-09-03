namespace Mémoire_SI
{
    partial class Sortie_de_stockVue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fournisseurs_tblTableAdapter = new Mémoire_SI.si_dbDataSet3TableAdapters.fournisseurs_tblTableAdapter();
            this.Sortie_de_stockDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Supprimer_sortie_de_stock = new Guna.UI2.WinForms.Guna2Button();
            this.Modifier_sortie_de_stock = new Guna.UI2.WinForms.Guna2Button();
            this.Ajouter_sortie_de_stock = new Guna.UI2.WinForms.Guna2Button();
            this.si_dbDataSet2 = new Mémoire_SI.si_dbDataSet2();
            this.medtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nom_du_medicament = new Guna.UI2.WinForms.Guna2ComboBox();
            this.categoryTableAdapter = new Mémoire_SI.si_dbDataSetTableAdapters.categoryTableAdapter();
            this.med_tblTableAdapter = new Mémoire_SI.si_dbDataSet2TableAdapters.med_tblTableAdapter();
            this.si_dbDataSet3 = new Mémoire_SI.si_dbDataSet3();
            this.fournisseurstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantité = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.si_dbDataSet = new Mémoire_SI.si_dbDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Date_achat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Nom_du_client = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sortie_de_stockDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fournisseurs_tblTableAdapter
            // 
            this.fournisseurs_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Sortie_de_stockDGV
            // 
            this.Sortie_de_stockDGV.AllowUserToAddRows = false;
            this.Sortie_de_stockDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Sortie_de_stockDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Sortie_de_stockDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Sortie_de_stockDGV.BackgroundColor = System.Drawing.Color.White;
            this.Sortie_de_stockDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sortie_de_stockDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Sortie_de_stockDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sortie_de_stockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Sortie_de_stockDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sortie_de_stockDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.Sortie_de_stockDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sortie_de_stockDGV.EnableHeadersVisualStyles = false;
            this.Sortie_de_stockDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Sortie_de_stockDGV.Location = new System.Drawing.Point(0, 370);
            this.Sortie_de_stockDGV.Name = "Sortie_de_stockDGV";
            this.Sortie_de_stockDGV.ReadOnly = true;
            this.Sortie_de_stockDGV.RowHeadersVisible = false;
            this.Sortie_de_stockDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Sortie_de_stockDGV.RowTemplate.Height = 28;
            this.Sortie_de_stockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sortie_de_stockDGV.Size = new System.Drawing.Size(1321, 402);
            this.Sortie_de_stockDGV.TabIndex = 43;
            this.Sortie_de_stockDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Sortie_de_stockDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Sortie_de_stockDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Sortie_de_stockDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Sortie_de_stockDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Sortie_de_stockDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Sortie_de_stockDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Sortie_de_stockDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Sortie_de_stockDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Sortie_de_stockDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Sortie_de_stockDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Sortie_de_stockDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Sortie_de_stockDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Sortie_de_stockDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.Sortie_de_stockDGV.ThemeStyle.ReadOnly = true;
            this.Sortie_de_stockDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Sortie_de_stockDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Sortie_de_stockDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Sortie_de_stockDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Sortie_de_stockDGV.ThemeStyle.RowsStyle.Height = 28;
            this.Sortie_de_stockDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Sortie_de_stockDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Sortie_de_stockDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sortie_de_stockDGV_CellContentClick);
            // 
            // Supprimer_sortie_de_stock
            // 
            this.Supprimer_sortie_de_stock.CheckedState.Parent = this.Supprimer_sortie_de_stock;
            this.Supprimer_sortie_de_stock.CustomImages.Parent = this.Supprimer_sortie_de_stock;
            this.Supprimer_sortie_de_stock.FillColor = System.Drawing.Color.Red;
            this.Supprimer_sortie_de_stock.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer_sortie_de_stock.ForeColor = System.Drawing.Color.White;
            this.Supprimer_sortie_de_stock.HoverState.Parent = this.Supprimer_sortie_de_stock;
            this.Supprimer_sortie_de_stock.Location = new System.Drawing.Point(950, 277);
            this.Supprimer_sortie_de_stock.Name = "Supprimer_sortie_de_stock";
            this.Supprimer_sortie_de_stock.ShadowDecoration.Parent = this.Supprimer_sortie_de_stock;
            this.Supprimer_sortie_de_stock.Size = new System.Drawing.Size(244, 60);
            this.Supprimer_sortie_de_stock.TabIndex = 42;
            this.Supprimer_sortie_de_stock.Text = "SUPPRIMER";
            this.Supprimer_sortie_de_stock.Click += new System.EventHandler(this.Sortie_de_stock_supp_btn_Click);
            // 
            // Modifier_sortie_de_stock
            // 
            this.Modifier_sortie_de_stock.CheckedState.Parent = this.Modifier_sortie_de_stock;
            this.Modifier_sortie_de_stock.CustomImages.Parent = this.Modifier_sortie_de_stock;
            this.Modifier_sortie_de_stock.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier_sortie_de_stock.ForeColor = System.Drawing.Color.White;
            this.Modifier_sortie_de_stock.HoverState.Parent = this.Modifier_sortie_de_stock;
            this.Modifier_sortie_de_stock.Location = new System.Drawing.Point(507, 277);
            this.Modifier_sortie_de_stock.Name = "Modifier_sortie_de_stock";
            this.Modifier_sortie_de_stock.ShadowDecoration.Parent = this.Modifier_sortie_de_stock;
            this.Modifier_sortie_de_stock.Size = new System.Drawing.Size(244, 60);
            this.Modifier_sortie_de_stock.TabIndex = 41;
            this.Modifier_sortie_de_stock.Text = "MODIFIER";
            this.Modifier_sortie_de_stock.Click += new System.EventHandler(this.Sortie_de_stock_modif_btn_Click);
            // 
            // Ajouter_sortie_de_stock
            // 
            this.Ajouter_sortie_de_stock.CheckedState.Parent = this.Ajouter_sortie_de_stock;
            this.Ajouter_sortie_de_stock.CustomImages.Parent = this.Ajouter_sortie_de_stock;
            this.Ajouter_sortie_de_stock.FillColor = System.Drawing.Color.Lime;
            this.Ajouter_sortie_de_stock.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_sortie_de_stock.ForeColor = System.Drawing.Color.White;
            this.Ajouter_sortie_de_stock.HoverState.Parent = this.Ajouter_sortie_de_stock;
            this.Ajouter_sortie_de_stock.Location = new System.Drawing.Point(87, 277);
            this.Ajouter_sortie_de_stock.Name = "Ajouter_sortie_de_stock";
            this.Ajouter_sortie_de_stock.ShadowDecoration.Parent = this.Ajouter_sortie_de_stock;
            this.Ajouter_sortie_de_stock.Size = new System.Drawing.Size(244, 60);
            this.Ajouter_sortie_de_stock.TabIndex = 40;
            this.Ajouter_sortie_de_stock.Text = "AJOUTER";
            this.Ajouter_sortie_de_stock.Click += new System.EventHandler(this.Sortie_de_stock_add_btn_Click);
            // 
            // si_dbDataSet2
            // 
            this.si_dbDataSet2.DataSetName = "si_dbDataSet2";
            this.si_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medtblBindingSource
            // 
            this.medtblBindingSource.DataMember = "med_tbl";
            this.medtblBindingSource.DataSource = this.si_dbDataSet2;
            // 
            // Nom_du_medicament
            // 
            this.Nom_du_medicament.BackColor = System.Drawing.Color.Transparent;
            this.Nom_du_medicament.DataSource = this.medtblBindingSource;
            this.Nom_du_medicament.DisplayMember = "Mednom";
            this.Nom_du_medicament.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Nom_du_medicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nom_du_medicament.FocusedColor = System.Drawing.Color.Empty;
            this.Nom_du_medicament.FocusedState.Parent = this.Nom_du_medicament;
            this.Nom_du_medicament.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_du_medicament.ForeColor = System.Drawing.Color.Black;
            this.Nom_du_medicament.FormattingEnabled = true;
            this.Nom_du_medicament.HoverState.Parent = this.Nom_du_medicament;
            this.Nom_du_medicament.ItemHeight = 30;
            this.Nom_du_medicament.ItemsAppearance.Parent = this.Nom_du_medicament;
            this.Nom_du_medicament.Location = new System.Drawing.Point(12, 39);
            this.Nom_du_medicament.Name = "Nom_du_medicament";
            this.Nom_du_medicament.ShadowDecoration.Parent = this.Nom_du_medicament;
            this.Nom_du_medicament.Size = new System.Drawing.Size(395, 36);
            this.Nom_du_medicament.TabIndex = 39;
            this.Nom_du_medicament.ValueMember = "MedId";
            this.Nom_du_medicament.SelectedIndexChanged += new System.EventHandler(this.Sortie_de_stock_mednomcb_SelectedIndexChanged);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // med_tblTableAdapter
            // 
            this.med_tblTableAdapter.ClearBeforeFill = true;
            // 
            // si_dbDataSet3
            // 
            this.si_dbDataSet3.DataSetName = "si_dbDataSet3";
            this.si_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fournisseurstblBindingSource
            // 
            this.fournisseurstblBindingSource.DataMember = "fournisseurs_tbl";
            this.fournisseurstblBindingSource.DataSource = this.si_dbDataSet3;
            // 
            // Quantité
            // 
            this.Quantité.BackColor = System.Drawing.Color.White;
            this.Quantité.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantité.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Quantité.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantité.LineColor = System.Drawing.Color.Gainsboro;
            this.Quantité.Location = new System.Drawing.Point(906, 39);
            this.Quantité.Name = "Quantité";
            this.Quantité.PasswordChar = '\0';
            this.Quantité.SelectedText = "";
            this.Quantité.Size = new System.Drawing.Size(231, 41);
            this.Quantité.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(900, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quantité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nom du médicament :";
            // 
            // si_dbDataSet
            // 
            this.si_dbDataSet.DataSetName = "si_dbDataSet";
            this.si_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.si_dbDataSet;
            // 
            // Date_achat
            // 
            this.Date_achat.CheckedState.Parent = this.Date_achat;
            this.Date_achat.FillColor = System.Drawing.Color.LightGreen;
            this.Date_achat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_achat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date_achat.HoverState.Parent = this.Date_achat;
            this.Date_achat.Location = new System.Drawing.Point(12, 133);
            this.Date_achat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_achat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_achat.Name = "Date_achat";
            this.Date_achat.ShadowDecoration.Parent = this.Date_achat;
            this.Date_achat.Size = new System.Drawing.Size(349, 49);
            this.Date_achat.TabIndex = 36;
            this.Date_achat.Value = new System.DateTime(2023, 11, 23, 11, 35, 49, 267);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date de l\'opération :";
            // 
            // Nom_du_client
            // 
            this.Nom_du_client.BackColor = System.Drawing.Color.White;
            this.Nom_du_client.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nom_du_client.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Nom_du_client.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_du_client.LineColor = System.Drawing.Color.Gainsboro;
            this.Nom_du_client.Location = new System.Drawing.Point(507, 43);
            this.Nom_du_client.Name = "Nom_du_client";
            this.Nom_du_client.PasswordChar = '\0';
            this.Nom_du_client.SelectedText = "";
            this.Nom_du_client.Size = new System.Drawing.Size(321, 41);
            this.Nom_du_client.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nom client :";
            // 
            // Sortie_de_stockVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 772);
            this.Controls.Add(this.Nom_du_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sortie_de_stockDGV);
            this.Controls.Add(this.Supprimer_sortie_de_stock);
            this.Controls.Add(this.Modifier_sortie_de_stock);
            this.Controls.Add(this.Ajouter_sortie_de_stock);
            this.Controls.Add(this.Nom_du_medicament);
            this.Controls.Add(this.Quantité);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_achat);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sortie_de_stockVue";
            this.Text = "caisse";
            ((System.ComponentModel.ISupportInitialize)(this.Sortie_de_stockDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private si_dbDataSet3TableAdapters.fournisseurs_tblTableAdapter fournisseurs_tblTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView Sortie_de_stockDGV;
        private Guna.UI2.WinForms.Guna2Button Supprimer_sortie_de_stock;
        private Guna.UI2.WinForms.Guna2Button Modifier_sortie_de_stock;
        private Guna.UI2.WinForms.Guna2Button Ajouter_sortie_de_stock;
        private si_dbDataSet2 si_dbDataSet2;
        private System.Windows.Forms.BindingSource medtblBindingSource;
        private Guna.UI2.WinForms.Guna2ComboBox Nom_du_medicament;
        private si_dbDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private si_dbDataSet2TableAdapters.med_tblTableAdapter med_tblTableAdapter;
        private si_dbDataSet3 si_dbDataSet3;
        private System.Windows.Forms.BindingSource fournisseurstblBindingSource;
        private Guna.UI.WinForms.GunaLineTextBox Quantité;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private si_dbDataSet si_dbDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date_achat;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox Nom_du_client;
        private System.Windows.Forms.Label label3;
    }
}
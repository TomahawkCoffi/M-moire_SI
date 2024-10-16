namespace Mémoire_SI
{
    partial class Entree_de_stocksVue
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
            this.label4 = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.si_dbDataSet = new Mémoire_SI.si_dbDataSet();
            this.entree_de_stock_qte = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entree_de_stock_fseurnomcb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fournisseurstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.si_dbDataSet3 = new Mémoire_SI.si_dbDataSet3();
            this.label5 = new System.Windows.Forms.Label();
            this.medlivdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.medvaldate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new Mémoire_SI.si_dbDataSetTableAdapters.categoryTableAdapter();
            this.entree_de_stock_mednomcb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.medtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.si_dbDataSet2 = new Mémoire_SI.si_dbDataSet2();
            this.entree_de_stock_supp_btn = new Guna.UI2.WinForms.Guna2Button();
            this.entree_de_stock_modif_btn = new Guna.UI2.WinForms.Guna2Button();
            this.entree_de_stock_add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Entree_de_stockDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.med_tblTableAdapter = new Mémoire_SI.si_dbDataSet2TableAdapters.med_tblTableAdapter();
            this.fournisseurs_tblTableAdapter = new Mémoire_SI.si_dbDataSet3TableAdapters.fournisseurs_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entree_de_stockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date livraison :";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.si_dbDataSet;
            // 
            // si_dbDataSet
            // 
            this.si_dbDataSet.DataSetName = "si_dbDataSet";
            this.si_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entree_de_stock_qte
            // 
            this.entree_de_stock_qte.BackColor = System.Drawing.Color.White;
            this.entree_de_stock_qte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.entree_de_stock_qte.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.entree_de_stock_qte.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entree_de_stock_qte.LineColor = System.Drawing.Color.Gainsboro;
            this.entree_de_stock_qte.Location = new System.Drawing.Point(906, 43);
            this.entree_de_stock_qte.Name = "entree_de_stock_qte";
            this.entree_de_stock_qte.PasswordChar = '\0';
            this.entree_de_stock_qte.SelectedText = "";
            this.entree_de_stock_qte.Size = new System.Drawing.Size(231, 41);
            this.entree_de_stock_qte.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(900, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom du médicament :";
            // 
            // entree_de_stock_fseurnomcb
            // 
            this.entree_de_stock_fseurnomcb.BackColor = System.Drawing.Color.Transparent;
            this.entree_de_stock_fseurnomcb.DataSource = this.fournisseurstblBindingSource;
            this.entree_de_stock_fseurnomcb.DisplayMember = "Fnom";
            this.entree_de_stock_fseurnomcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entree_de_stock_fseurnomcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entree_de_stock_fseurnomcb.FocusedColor = System.Drawing.Color.Empty;
            this.entree_de_stock_fseurnomcb.FocusedState.Parent = this.entree_de_stock_fseurnomcb;
            this.entree_de_stock_fseurnomcb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entree_de_stock_fseurnomcb.ForeColor = System.Drawing.Color.Black;
            this.entree_de_stock_fseurnomcb.FormattingEnabled = true;
            this.entree_de_stock_fseurnomcb.HoverState.Parent = this.entree_de_stock_fseurnomcb;
            this.entree_de_stock_fseurnomcb.ItemHeight = 30;
            this.entree_de_stock_fseurnomcb.ItemsAppearance.Parent = this.entree_de_stock_fseurnomcb;
            this.entree_de_stock_fseurnomcb.Location = new System.Drawing.Point(461, 43);
            this.entree_de_stock_fseurnomcb.Name = "entree_de_stock_fseurnomcb";
            this.entree_de_stock_fseurnomcb.ShadowDecoration.Parent = this.entree_de_stock_fseurnomcb;
            this.entree_de_stock_fseurnomcb.Size = new System.Drawing.Size(350, 36);
            this.entree_de_stock_fseurnomcb.TabIndex = 21;
            this.entree_de_stock_fseurnomcb.ValueMember = "FId";
            this.entree_de_stock_fseurnomcb.SelectedIndexChanged += new System.EventHandler(this.Medfseurcb_SelectedIndexChanged);
            // 
            // fournisseurstblBindingSource
            // 
            this.fournisseurstblBindingSource.DataMember = "fournisseurs_tbl";
            this.fournisseurstblBindingSource.DataSource = this.si_dbDataSet3;
            // 
            // si_dbDataSet3
            // 
            this.si_dbDataSet3.DataSetName = "si_dbDataSet3";
            this.si_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fournisseur :";
            // 
            // medlivdate
            // 
            this.medlivdate.BorderRadius = 5;
            this.medlivdate.CheckedState.Parent = this.medlivdate;
            this.medlivdate.FillColor = System.Drawing.Color.DarkOrchid;
            this.medlivdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medlivdate.ForeColor = System.Drawing.Color.White;
            this.medlivdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.medlivdate.HoverState.Parent = this.medlivdate;
            this.medlivdate.Location = new System.Drawing.Point(12, 137);
            this.medlivdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.medlivdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.medlivdate.Name = "medlivdate";
            this.medlivdate.ShadowDecoration.Parent = this.medlivdate;
            this.medlivdate.Size = new System.Drawing.Size(349, 49);
            this.medlivdate.TabIndex = 22;
            this.medlivdate.Value = new System.DateTime(2023, 11, 23, 11, 35, 49, 267);
            // 
            // medvaldate
            // 
            this.medvaldate.BorderRadius = 5;
            this.medvaldate.CheckedState.Parent = this.medvaldate;
            this.medvaldate.FillColor = System.Drawing.Color.DarkOrchid;
            this.medvaldate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medvaldate.ForeColor = System.Drawing.Color.White;
            this.medvaldate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.medvaldate.HoverState.Parent = this.medvaldate;
            this.medvaldate.Location = new System.Drawing.Point(461, 137);
            this.medvaldate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.medvaldate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.medvaldate.Name = "medvaldate";
            this.medvaldate.ShadowDecoration.Parent = this.medvaldate;
            this.medvaldate.Size = new System.Drawing.Size(406, 49);
            this.medvaldate.TabIndex = 24;
            this.medvaldate.Value = new System.DateTime(2023, 11, 23, 11, 35, 49, 267);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date de péremption :";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // entree_de_stock_mednomcb
            // 
            this.entree_de_stock_mednomcb.BackColor = System.Drawing.Color.Transparent;
            this.entree_de_stock_mednomcb.DataSource = this.medtblBindingSource;
            this.entree_de_stock_mednomcb.DisplayMember = "Mednom";
            this.entree_de_stock_mednomcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entree_de_stock_mednomcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entree_de_stock_mednomcb.FocusedColor = System.Drawing.Color.Empty;
            this.entree_de_stock_mednomcb.FocusedState.Parent = this.entree_de_stock_mednomcb;
            this.entree_de_stock_mednomcb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entree_de_stock_mednomcb.ForeColor = System.Drawing.Color.Black;
            this.entree_de_stock_mednomcb.FormattingEnabled = true;
            this.entree_de_stock_mednomcb.HoverState.Parent = this.entree_de_stock_mednomcb;
            this.entree_de_stock_mednomcb.ItemHeight = 30;
            this.entree_de_stock_mednomcb.ItemsAppearance.Parent = this.entree_de_stock_mednomcb;
            this.entree_de_stock_mednomcb.Location = new System.Drawing.Point(12, 43);
            this.entree_de_stock_mednomcb.Name = "entree_de_stock_mednomcb";
            this.entree_de_stock_mednomcb.ShadowDecoration.Parent = this.entree_de_stock_mednomcb;
            this.entree_de_stock_mednomcb.Size = new System.Drawing.Size(395, 36);
            this.entree_de_stock_mednomcb.TabIndex = 25;
            this.entree_de_stock_mednomcb.ValueMember = "MedId";
            // 
            // medtblBindingSource
            // 
            this.medtblBindingSource.DataMember = "med_tbl";
            this.medtblBindingSource.DataSource = this.si_dbDataSet2;
            // 
            // si_dbDataSet2
            // 
            this.si_dbDataSet2.DataSetName = "si_dbDataSet2";
            this.si_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entree_de_stock_supp_btn
            // 
            this.entree_de_stock_supp_btn.BorderRadius = 5;
            this.entree_de_stock_supp_btn.CheckedState.Parent = this.entree_de_stock_supp_btn;
            this.entree_de_stock_supp_btn.CustomImages.Parent = this.entree_de_stock_supp_btn;
            this.entree_de_stock_supp_btn.FillColor = System.Drawing.Color.DarkOrchid;
            this.entree_de_stock_supp_btn.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entree_de_stock_supp_btn.ForeColor = System.Drawing.Color.White;
            this.entree_de_stock_supp_btn.HoverState.Parent = this.entree_de_stock_supp_btn;
            this.entree_de_stock_supp_btn.Image = global::Mémoire_SI.Properties.Resources.icons8_supprimer_pour_toujours_50;
            this.entree_de_stock_supp_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.entree_de_stock_supp_btn.Location = new System.Drawing.Point(950, 281);
            this.entree_de_stock_supp_btn.Name = "entree_de_stock_supp_btn";
            this.entree_de_stock_supp_btn.ShadowDecoration.Parent = this.entree_de_stock_supp_btn;
            this.entree_de_stock_supp_btn.Size = new System.Drawing.Size(244, 60);
            this.entree_de_stock_supp_btn.TabIndex = 28;
            this.entree_de_stock_supp_btn.Text = "SUPPRIMER";
            this.entree_de_stock_supp_btn.Click += new System.EventHandler(this.Entree_de_stock_supp_btn_Click);
            // 
            // entree_de_stock_modif_btn
            // 
            this.entree_de_stock_modif_btn.BorderRadius = 5;
            this.entree_de_stock_modif_btn.CheckedState.Parent = this.entree_de_stock_modif_btn;
            this.entree_de_stock_modif_btn.CustomImages.Parent = this.entree_de_stock_modif_btn;
            this.entree_de_stock_modif_btn.FillColor = System.Drawing.Color.DarkOrchid;
            this.entree_de_stock_modif_btn.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entree_de_stock_modif_btn.ForeColor = System.Drawing.Color.White;
            this.entree_de_stock_modif_btn.HoverState.Parent = this.entree_de_stock_modif_btn;
            this.entree_de_stock_modif_btn.Image = global::Mémoire_SI.Properties.Resources.icons8_boucle_50;
            this.entree_de_stock_modif_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.entree_de_stock_modif_btn.Location = new System.Drawing.Point(507, 281);
            this.entree_de_stock_modif_btn.Name = "entree_de_stock_modif_btn";
            this.entree_de_stock_modif_btn.ShadowDecoration.Parent = this.entree_de_stock_modif_btn;
            this.entree_de_stock_modif_btn.Size = new System.Drawing.Size(244, 60);
            this.entree_de_stock_modif_btn.TabIndex = 27;
            this.entree_de_stock_modif_btn.Text = "MODIFIER";
            this.entree_de_stock_modif_btn.Click += new System.EventHandler(this.Entree_de_stock_modif_btn_Click);
            // 
            // entree_de_stock_add_btn
            // 
            this.entree_de_stock_add_btn.BorderRadius = 5;
            this.entree_de_stock_add_btn.CheckedState.Parent = this.entree_de_stock_add_btn;
            this.entree_de_stock_add_btn.CustomImages.Parent = this.entree_de_stock_add_btn;
            this.entree_de_stock_add_btn.FillColor = System.Drawing.Color.DarkOrchid;
            this.entree_de_stock_add_btn.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entree_de_stock_add_btn.ForeColor = System.Drawing.Color.White;
            this.entree_de_stock_add_btn.HoverState.Parent = this.entree_de_stock_add_btn;
            this.entree_de_stock_add_btn.Image = global::Mémoire_SI.Properties.Resources.icons8_approved_48;
            this.entree_de_stock_add_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.entree_de_stock_add_btn.Location = new System.Drawing.Point(87, 281);
            this.entree_de_stock_add_btn.Name = "entree_de_stock_add_btn";
            this.entree_de_stock_add_btn.ShadowDecoration.Parent = this.entree_de_stock_add_btn;
            this.entree_de_stock_add_btn.Size = new System.Drawing.Size(244, 60);
            this.entree_de_stock_add_btn.TabIndex = 26;
            this.entree_de_stock_add_btn.Text = "AJOUTER";
            this.entree_de_stock_add_btn.Click += new System.EventHandler(this.Medaddbtn_Click_1);
            // 
            // Entree_de_stockDGV
            // 
            this.Entree_de_stockDGV.AllowUserToAddRows = false;
            this.Entree_de_stockDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Entree_de_stockDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Entree_de_stockDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Entree_de_stockDGV.BackgroundColor = System.Drawing.Color.White;
            this.Entree_de_stockDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Entree_de_stockDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Entree_de_stockDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Entree_de_stockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Entree_de_stockDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Entree_de_stockDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.Entree_de_stockDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Entree_de_stockDGV.EnableHeadersVisualStyles = false;
            this.Entree_de_stockDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Entree_de_stockDGV.Location = new System.Drawing.Point(0, 370);
            this.Entree_de_stockDGV.Name = "Entree_de_stockDGV";
            this.Entree_de_stockDGV.ReadOnly = true;
            this.Entree_de_stockDGV.RowHeadersVisible = false;
            this.Entree_de_stockDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Entree_de_stockDGV.RowTemplate.Height = 28;
            this.Entree_de_stockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Entree_de_stockDGV.Size = new System.Drawing.Size(1321, 402);
            this.Entree_de_stockDGV.TabIndex = 29;
            this.Entree_de_stockDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Entree_de_stockDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Entree_de_stockDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Entree_de_stockDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Entree_de_stockDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Entree_de_stockDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Entree_de_stockDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Entree_de_stockDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Entree_de_stockDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Entree_de_stockDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Entree_de_stockDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Entree_de_stockDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Entree_de_stockDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Entree_de_stockDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.Entree_de_stockDGV.ThemeStyle.ReadOnly = true;
            this.Entree_de_stockDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Entree_de_stockDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Entree_de_stockDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entree_de_stockDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Entree_de_stockDGV.ThemeStyle.RowsStyle.Height = 28;
            this.Entree_de_stockDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Entree_de_stockDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Entree_de_stockDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Entree_de_stockDGV_CellContentClick);
            // 
            // med_tblTableAdapter
            // 
            this.med_tblTableAdapter.ClearBeforeFill = true;
            // 
            // fournisseurs_tblTableAdapter
            // 
            this.fournisseurs_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Entree_de_stocksVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 772);
            this.Controls.Add(this.Entree_de_stockDGV);
            this.Controls.Add(this.entree_de_stock_supp_btn);
            this.Controls.Add(this.entree_de_stock_modif_btn);
            this.Controls.Add(this.entree_de_stock_add_btn);
            this.Controls.Add(this.entree_de_stock_mednomcb);
            this.Controls.Add(this.medvaldate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medlivdate);
            this.Controls.Add(this.entree_de_stock_fseurnomcb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entree_de_stock_qte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entree_de_stocksVue";
            this.Text = "livraison";
            this.Load += new System.EventHandler(this.Livraison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entree_de_stockDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox entree_de_stock_qte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox entree_de_stock_fseurnomcb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker medlivdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker medvaldate;
        private System.Windows.Forms.Label label6;
        private si_dbDataSet si_dbDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private si_dbDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox entree_de_stock_mednomcb;
        private Guna.UI2.WinForms.Guna2Button entree_de_stock_supp_btn;
        private Guna.UI2.WinForms.Guna2Button entree_de_stock_modif_btn;
        private Guna.UI2.WinForms.Guna2Button entree_de_stock_add_btn;
        private Guna.UI2.WinForms.Guna2DataGridView Entree_de_stockDGV;
        private si_dbDataSet2 si_dbDataSet2;
        private System.Windows.Forms.BindingSource medtblBindingSource;
        private si_dbDataSet2TableAdapters.med_tblTableAdapter med_tblTableAdapter;
        private si_dbDataSet3 si_dbDataSet3;
        private System.Windows.Forms.BindingSource fournisseurstblBindingSource;
        private si_dbDataSet3TableAdapters.fournisseurs_tblTableAdapter fournisseurs_tblTableAdapter;
    }
}
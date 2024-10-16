namespace Mémoire_SI
{
    partial class FournisseurList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fseurnomtb = new System.Windows.Forms.TextBox();
            this.fseuraddtb = new System.Windows.Forms.TextBox();
            this.fseurnumtb = new System.Windows.Forms.TextBox();
            this.fseuraddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnmod = new Guna.UI2.WinForms.Guna2Button();
            this.btnsupp = new Guna.UI2.WinForms.Guna2Button();
            this.FseurDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FseurDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom fournisseur ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Addresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(923, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // fseurnomtb
            // 
            this.fseurnomtb.BackColor = System.Drawing.Color.White;
            this.fseurnomtb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fseurnomtb.Location = new System.Drawing.Point(20, 141);
            this.fseurnomtb.Name = "fseurnomtb";
            this.fseurnomtb.Size = new System.Drawing.Size(309, 38);
            this.fseurnomtb.TabIndex = 3;
            // 
            // fseuraddtb
            // 
            this.fseuraddtb.BackColor = System.Drawing.Color.White;
            this.fseuraddtb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fseuraddtb.Location = new System.Drawing.Point(478, 141);
            this.fseuraddtb.Multiline = true;
            this.fseuraddtb.Name = "fseuraddtb";
            this.fseuraddtb.Size = new System.Drawing.Size(292, 72);
            this.fseuraddtb.TabIndex = 4;
            this.fseuraddtb.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // fseurnumtb
            // 
            this.fseurnumtb.BackColor = System.Drawing.Color.White;
            this.fseurnumtb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fseurnumtb.Location = new System.Drawing.Point(931, 141);
            this.fseurnumtb.Name = "fseurnumtb";
            this.fseurnumtb.Size = new System.Drawing.Size(292, 38);
            this.fseurnumtb.TabIndex = 5;
            // 
            // fseuraddbtn
            // 
            this.fseuraddbtn.BorderRadius = 5;
            this.fseuraddbtn.CheckedState.Parent = this.fseuraddbtn;
            this.fseuraddbtn.CustomImages.Parent = this.fseuraddbtn;
            this.fseuraddbtn.FillColor = System.Drawing.Color.DarkOrchid;
            this.fseuraddbtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fseuraddbtn.ForeColor = System.Drawing.Color.White;
            this.fseuraddbtn.HoverState.Parent = this.fseuraddbtn;
            this.fseuraddbtn.Image = global::Mémoire_SI.Properties.Resources.icons8_approved_48;
            this.fseuraddbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fseuraddbtn.Location = new System.Drawing.Point(68, 281);
            this.fseuraddbtn.Name = "fseuraddbtn";
            this.fseuraddbtn.ShadowDecoration.Parent = this.fseuraddbtn;
            this.fseuraddbtn.Size = new System.Drawing.Size(244, 60);
            this.fseuraddbtn.TabIndex = 6;
            this.fseuraddbtn.Text = "AJOUTER";
            this.fseuraddbtn.Click += new System.EventHandler(this.Fseuraddbtn_Click);
            // 
            // btnmod
            // 
            this.btnmod.BorderRadius = 5;
            this.btnmod.CheckedState.Parent = this.btnmod;
            this.btnmod.CustomImages.Parent = this.btnmod;
            this.btnmod.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnmod.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.ForeColor = System.Drawing.Color.White;
            this.btnmod.HoverState.Parent = this.btnmod;
            this.btnmod.Image = global::Mémoire_SI.Properties.Resources.icons8_boucle_50;
            this.btnmod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnmod.Location = new System.Drawing.Point(478, 281);
            this.btnmod.Name = "btnmod";
            this.btnmod.ShadowDecoration.Parent = this.btnmod;
            this.btnmod.Size = new System.Drawing.Size(244, 60);
            this.btnmod.TabIndex = 7;
            this.btnmod.Text = "MODIFIER";
            this.btnmod.Click += new System.EventHandler(this.Btnmod_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.BorderRadius = 5;
            this.btnsupp.CheckedState.Parent = this.btnsupp;
            this.btnsupp.CustomImages.Parent = this.btnsupp;
            this.btnsupp.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnsupp.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.ForeColor = System.Drawing.Color.White;
            this.btnsupp.HoverState.Parent = this.btnsupp;
            this.btnsupp.Image = global::Mémoire_SI.Properties.Resources.icons8_supprimer_pour_toujours_50;
            this.btnsupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnsupp.Location = new System.Drawing.Point(931, 281);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.ShadowDecoration.Parent = this.btnsupp;
            this.btnsupp.Size = new System.Drawing.Size(244, 60);
            this.btnsupp.TabIndex = 8;
            this.btnsupp.Text = "SUPPRIMER";
            this.btnsupp.Click += new System.EventHandler(this.Btnsupp_Click);
            // 
            // FseurDGV
            // 
            this.FseurDGV.AllowUserToAddRows = false;
            this.FseurDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.FseurDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.FseurDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FseurDGV.BackgroundColor = System.Drawing.Color.White;
            this.FseurDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FseurDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FseurDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FseurDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.FseurDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FseurDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.FseurDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FseurDGV.EnableHeadersVisualStyles = false;
            this.FseurDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FseurDGV.Location = new System.Drawing.Point(0, 366);
            this.FseurDGV.Name = "FseurDGV";
            this.FseurDGV.ReadOnly = true;
            this.FseurDGV.RowHeadersVisible = false;
            this.FseurDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.FseurDGV.RowTemplate.Height = 28;
            this.FseurDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FseurDGV.Size = new System.Drawing.Size(1303, 359);
            this.FseurDGV.TabIndex = 9;
            this.FseurDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.FseurDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FseurDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FseurDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FseurDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FseurDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FseurDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FseurDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FseurDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FseurDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FseurDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FseurDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FseurDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FseurDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.FseurDGV.ThemeStyle.ReadOnly = true;
            this.FseurDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FseurDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FseurDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FseurDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FseurDGV.ThemeStyle.RowsStyle.Height = 28;
            this.FseurDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FseurDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FseurDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FseurDGV_CellContentClick);
            // 
            // FournisseurList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 725);
            this.Controls.Add(this.FseurDGV);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.fseuraddbtn);
            this.Controls.Add(this.fseurnumtb);
            this.Controls.Add(this.fseuraddtb);
            this.Controls.Add(this.fseurnomtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FournisseurList";
            this.Text = "fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.FseurDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fseurnomtb;
        private System.Windows.Forms.TextBox fseuraddtb;
        private System.Windows.Forms.TextBox fseurnumtb;
        private Guna.UI2.WinForms.Guna2Button fseuraddbtn;
        private Guna.UI2.WinForms.Guna2Button btnmod;
        private Guna.UI2.WinForms.Guna2Button btnsupp;
        private Guna.UI2.WinForms.Guna2DataGridView FseurDGV;
    }
}
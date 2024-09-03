using System;

namespace Mémoire_SI
{
    partial class frmregister
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
            this.usertxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.mdptxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.commpdtxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.checkbmdp = new Guna.UI2.WinForms.Guna2CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rolecombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.White;
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usertxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.LineColor = System.Drawing.Color.Gainsboro;
            this.usertxt.LineSize = 5;
            this.usertxt.Location = new System.Drawing.Point(23, 169);
            this.usertxt.Name = "usertxt";
            this.usertxt.PasswordChar = '\0';
            this.usertxt.SelectedText = "";
            this.usertxt.Size = new System.Drawing.Size(330, 41);
            this.usertxt.TabIndex = 1;
            // 
            // mdptxt
            // 
            this.mdptxt.BackColor = System.Drawing.Color.White;
            this.mdptxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mdptxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.mdptxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdptxt.LineColor = System.Drawing.Color.Gainsboro;
            this.mdptxt.LineSize = 5;
            this.mdptxt.Location = new System.Drawing.Point(23, 307);
            this.mdptxt.Name = "mdptxt";
            this.mdptxt.PasswordChar = '•';
            this.mdptxt.SelectedText = "";
            this.mdptxt.Size = new System.Drawing.Size(330, 42);
            this.mdptxt.TabIndex = 2;
            this.mdptxt.TextChanged += new System.EventHandler(this.mdptxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 754);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vous avez déjà un compte ?";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(107, 655);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(349, 48);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.TabStop = false;
            this.guna2Button2.Text = "Effacer";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 747);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Créer un nouveau compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirmer Mot de passe";
            // 
            // commpdtxt
            // 
            this.commpdtxt.BackColor = System.Drawing.Color.White;
            this.commpdtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commpdtxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.commpdtxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commpdtxt.LineColor = System.Drawing.Color.Gainsboro;
            this.commpdtxt.LineSize = 5;
            this.commpdtxt.Location = new System.Drawing.Point(23, 460);
            this.commpdtxt.Name = "commpdtxt";
            this.commpdtxt.PasswordChar = '•';
            this.commpdtxt.SelectedText = "";
            this.commpdtxt.Size = new System.Drawing.Size(330, 42);
            this.commpdtxt.TabIndex = 11;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(107, 591);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(349, 48);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.TabStop = false;
            this.guna2Button1.Text = "Valider";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // checkbmdp
            // 
            this.checkbmdp.AutoSize = true;
            this.checkbmdp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbmdp.CheckedState.BorderRadius = 2;
            this.checkbmdp.CheckedState.BorderThickness = 0;
            this.checkbmdp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbmdp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbmdp.Location = new System.Drawing.Point(183, 508);
            this.checkbmdp.Name = "checkbmdp";
            this.checkbmdp.Size = new System.Drawing.Size(185, 29);
            this.checkbmdp.TabIndex = 14;
            this.checkbmdp.Text = "Voir mot de passe";
            this.checkbmdp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbmdp.UncheckedState.BorderRadius = 2;
            this.checkbmdp.UncheckedState.BorderThickness = 0;
            this.checkbmdp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbmdp.UseVisualStyleBackColor = true;
            this.checkbmdp.CheckedChanged += new System.EventHandler(this.checkbmdp_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(529, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rolecombobox
            // 
            this.rolecombobox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolecombobox.FormattingEnabled = true;
            this.rolecombobox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.rolecombobox.Location = new System.Drawing.Point(340, 117);
            this.rolecombobox.Name = "rolecombobox";
            this.rolecombobox.Size = new System.Drawing.Size(229, 39);
            this.rolecombobox.TabIndex = 16;
            this.rolecombobox.Text = "sélectionner un rôle";
            // 
            // frmregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 787);
            this.Controls.Add(this.rolecombobox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkbmdp);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.commpdtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdptxt);
            this.Controls.Add(this.usertxt);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmregister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmregister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox usertxt;
        private Guna.UI.WinForms.GunaLineTextBox mdptxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox commpdtxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CheckBox checkbmdp;
        private EventHandler gunaLineTextBox1_TextChanged;
        private EventHandler gunaLineTextBox2_TextChanged;
        private EventHandler label1_Click;
        private EventHandler label3_Click;
        private EventHandler label4_Click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox rolecombobox;
    }
}
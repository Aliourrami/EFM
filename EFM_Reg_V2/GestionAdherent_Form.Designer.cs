namespace EFM_Reg_V2
{
    partial class GestionAdherent_Form
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
            this.tb_CodeAdh = new System.Windows.Forms.TextBox();
            this.tb_NomAdh = new System.Windows.Forms.TextBox();
            this.tb_PrenomAdh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Premier = new System.Windows.Forms.Button();
            this.btn_Precedent = new System.Windows.Forms.Button();
            this.btn_Suivant = new System.Windows.Forms.Button();
            this.btn_Dernier = new System.Windows.Forms.Button();
            this.dgv_Adh = new System.Windows.Forms.DataGridView();
            this.rb_Tous = new System.Windows.Forms.RadioButton();
            this.rb_nom = new System.Windows.Forms.RadioButton();
            this.tb_rech = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adh)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_CodeAdh
            // 
            this.tb_CodeAdh.Location = new System.Drawing.Point(214, 38);
            this.tb_CodeAdh.Name = "tb_CodeAdh";
            this.tb_CodeAdh.Size = new System.Drawing.Size(100, 20);
            this.tb_CodeAdh.TabIndex = 0;
            // 
            // tb_NomAdh
            // 
            this.tb_NomAdh.Location = new System.Drawing.Point(214, 78);
            this.tb_NomAdh.Name = "tb_NomAdh";
            this.tb_NomAdh.Size = new System.Drawing.Size(100, 20);
            this.tb_NomAdh.TabIndex = 1;
            // 
            // tb_PrenomAdh
            // 
            this.tb_PrenomAdh.Location = new System.Drawing.Point(214, 119);
            this.tb_PrenomAdh.Name = "tb_PrenomAdh";
            this.tb_PrenomAdh.Size = new System.Drawing.Size(100, 20);
            this.tb_PrenomAdh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CodeAdh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NomAdh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PrenomAdh";
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(184, 157);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 6;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Premier
            // 
            this.btn_Premier.Location = new System.Drawing.Point(52, 192);
            this.btn_Premier.Name = "btn_Premier";
            this.btn_Premier.Size = new System.Drawing.Size(75, 23);
            this.btn_Premier.TabIndex = 7;
            this.btn_Premier.Text = "Premier";
            this.btn_Premier.UseVisualStyleBackColor = true;
            this.btn_Premier.Click += new System.EventHandler(this.btn_Premier_Click);
            // 
            // btn_Precedent
            // 
            this.btn_Precedent.Location = new System.Drawing.Point(133, 192);
            this.btn_Precedent.Name = "btn_Precedent";
            this.btn_Precedent.Size = new System.Drawing.Size(75, 23);
            this.btn_Precedent.TabIndex = 8;
            this.btn_Precedent.Text = "Precedent";
            this.btn_Precedent.UseVisualStyleBackColor = true;
            this.btn_Precedent.Click += new System.EventHandler(this.btn_Precedent_Click);
            // 
            // btn_Suivant
            // 
            this.btn_Suivant.Location = new System.Drawing.Point(214, 192);
            this.btn_Suivant.Name = "btn_Suivant";
            this.btn_Suivant.Size = new System.Drawing.Size(75, 23);
            this.btn_Suivant.TabIndex = 9;
            this.btn_Suivant.Text = "Suivant";
            this.btn_Suivant.UseVisualStyleBackColor = true;
            this.btn_Suivant.Click += new System.EventHandler(this.btn_Suivant_Click);
            // 
            // btn_Dernier
            // 
            this.btn_Dernier.Location = new System.Drawing.Point(295, 192);
            this.btn_Dernier.Name = "btn_Dernier";
            this.btn_Dernier.Size = new System.Drawing.Size(75, 23);
            this.btn_Dernier.TabIndex = 10;
            this.btn_Dernier.Text = "Dernier";
            this.btn_Dernier.UseVisualStyleBackColor = true;
            this.btn_Dernier.Click += new System.EventHandler(this.btn_Dernier_Click);
            // 
            // dgv_Adh
            // 
            this.dgv_Adh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Adh.Location = new System.Drawing.Point(38, 291);
            this.dgv_Adh.Name = "dgv_Adh";
            this.dgv_Adh.Size = new System.Drawing.Size(359, 150);
            this.dgv_Adh.TabIndex = 11;
            this.dgv_Adh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Adh_CellContentClick);
            // 
            // rb_Tous
            // 
            this.rb_Tous.AutoSize = true;
            this.rb_Tous.Location = new System.Drawing.Point(88, 250);
            this.rb_Tous.Name = "rb_Tous";
            this.rb_Tous.Size = new System.Drawing.Size(49, 17);
            this.rb_Tous.TabIndex = 12;
            this.rb_Tous.TabStop = true;
            this.rb_Tous.Text = "Tous";
            this.rb_Tous.UseVisualStyleBackColor = true;
            this.rb_Tous.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_nom
            // 
            this.rb_nom.AutoSize = true;
            this.rb_nom.Location = new System.Drawing.Point(179, 250);
            this.rb_nom.Name = "rb_nom";
            this.rb_nom.Size = new System.Drawing.Size(45, 17);
            this.rb_nom.TabIndex = 13;
            this.rb_nom.TabStop = true;
            this.rb_nom.Text = "nom";
            this.rb_nom.UseVisualStyleBackColor = true;
            this.rb_nom.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tb_rech
            // 
            this.tb_rech.Location = new System.Drawing.Point(270, 250);
            this.tb_rech.Name = "tb_rech";
            this.tb_rech.Size = new System.Drawing.Size(83, 20);
            this.tb_rech.TabIndex = 14;
            // 
            // GestionAdherent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 443);
            this.Controls.Add(this.tb_rech);
            this.Controls.Add(this.rb_nom);
            this.Controls.Add(this.rb_Tous);
            this.Controls.Add(this.dgv_Adh);
            this.Controls.Add(this.btn_Dernier);
            this.Controls.Add(this.btn_Suivant);
            this.Controls.Add(this.btn_Precedent);
            this.Controls.Add(this.btn_Premier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_PrenomAdh);
            this.Controls.Add(this.tb_NomAdh);
            this.Controls.Add(this.tb_CodeAdh);
            this.Name = "GestionAdherent_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CodeAdh;
        private System.Windows.Forms.TextBox tb_NomAdh;
        private System.Windows.Forms.TextBox tb_PrenomAdh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Premier;
        private System.Windows.Forms.Button btn_Precedent;
        private System.Windows.Forms.Button btn_Suivant;
        private System.Windows.Forms.Button btn_Dernier;
        private System.Windows.Forms.DataGridView dgv_Adh;
        private System.Windows.Forms.RadioButton rb_Tous;
        private System.Windows.Forms.RadioButton rb_nom;
        private System.Windows.Forms.TextBox tb_rech;
    }
}


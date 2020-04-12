namespace EFM_Reg_V2
{
    partial class GestionEmprunt_Form
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
            this.cbx_Adh = new System.Windows.Forms.ComboBox();
            this.cbx_Film = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Adh = new System.Windows.Forms.DataGridView();
            this.DGV_Film = new System.Windows.Forms.DataGridView();
            this.DTP_DateEmp = new System.Windows.Forms.DateTimePicker();
            this.DTP_DateRet = new System.Windows.Forms.DateTimePicker();
            this.tb_CodeAdh = new System.Windows.Forms.TextBox();
            this.tb_CodeFilm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CodeFilm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Film)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Adh
            // 
            this.cbx_Adh.FormattingEnabled = true;
            this.cbx_Adh.Location = new System.Drawing.Point(139, 245);
            this.cbx_Adh.Name = "cbx_Adh";
            this.cbx_Adh.Size = new System.Drawing.Size(121, 21);
            this.cbx_Adh.TabIndex = 0;
            this.cbx_Adh.SelectedIndexChanged += new System.EventHandler(this.cbx_Adh_SelectedIndexChanged);
            // 
            // cbx_Film
            // 
            this.cbx_Film.FormattingEnabled = true;
            this.cbx_Film.Location = new System.Drawing.Point(544, 245);
            this.cbx_Film.Name = "cbx_Film";
            this.cbx_Film.Size = new System.Drawing.Size(121, 21);
            this.cbx_Film.TabIndex = 1;
            this.cbx_Film.SelectedIndexChanged += new System.EventHandler(this.cbx_Film_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste Adherents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste Films";
            // 
            // DGV_Adh
            // 
            this.DGV_Adh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Adh.Location = new System.Drawing.Point(12, 284);
            this.DGV_Adh.Name = "DGV_Adh";
            this.DGV_Adh.Size = new System.Drawing.Size(363, 171);
            this.DGV_Adh.TabIndex = 3;
            // 
            // DGV_Film
            // 
            this.DGV_Film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Film.Location = new System.Drawing.Point(403, 284);
            this.DGV_Film.Name = "DGV_Film";
            this.DGV_Film.Size = new System.Drawing.Size(349, 171);
            this.DGV_Film.TabIndex = 3;
            // 
            // DTP_DateEmp
            // 
            this.DTP_DateEmp.Location = new System.Drawing.Point(139, 142);
            this.DTP_DateEmp.Name = "DTP_DateEmp";
            this.DTP_DateEmp.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateEmp.TabIndex = 4;
            // 
            // DTP_DateRet
            // 
            this.DTP_DateRet.Location = new System.Drawing.Point(139, 180);
            this.DTP_DateRet.Name = "DTP_DateRet";
            this.DTP_DateRet.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateRet.TabIndex = 5;
            // 
            // tb_CodeAdh
            // 
            this.tb_CodeAdh.Location = new System.Drawing.Point(139, 71);
            this.tb_CodeAdh.Name = "tb_CodeAdh";
            this.tb_CodeAdh.Size = new System.Drawing.Size(100, 20);
            this.tb_CodeAdh.TabIndex = 7;
            // 
            // tb_CodeFilm
            // 
            this.tb_CodeFilm.Location = new System.Drawing.Point(139, 97);
            this.tb_CodeFilm.Name = "tb_CodeFilm";
            this.tb_CodeFilm.Size = new System.Drawing.Size(100, 20);
            this.tb_CodeFilm.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CodeAdh";
            // 
            // CodeFilm
            // 
            this.CodeFilm.AutoSize = true;
            this.CodeFilm.Location = new System.Drawing.Point(72, 100);
            this.CodeFilm.Name = "CodeFilm";
            this.CodeFilm.Size = new System.Drawing.Size(50, 13);
            this.CodeFilm.TabIndex = 9;
            this.CodeFilm.Text = "CodeFilm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DateEmp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "DateRet";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(553, 100);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 10;
            this.btn_ajouter.Text = "ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // GestionEmprunt_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 501);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CodeFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_CodeFilm);
            this.Controls.Add(this.tb_CodeAdh);
            this.Controls.Add(this.DTP_DateRet);
            this.Controls.Add(this.DTP_DateEmp);
            this.Controls.Add(this.DGV_Film);
            this.Controls.Add(this.DGV_Adh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Film);
            this.Controls.Add(this.cbx_Adh);
            this.Name = "GestionEmprunt_Form";
            this.Text = "GestionEmprunt_Form";
            this.Load += new System.EventHandler(this.GestionEmprunt_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Film)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Adh;
        private System.Windows.Forms.ComboBox cbx_Film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Adh;
        private System.Windows.Forms.DataGridView DGV_Film;
        private System.Windows.Forms.DateTimePicker DTP_DateEmp;
        private System.Windows.Forms.DateTimePicker DTP_DateRet;
        private System.Windows.Forms.TextBox tb_CodeAdh;
        private System.Windows.Forms.TextBox tb_CodeFilm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CodeFilm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ajouter;
    }
}
namespace EFM_Reg_V2
{
    partial class GestionRetours_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_nomAdh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Adh
            // 
            this.cbx_Adh.FormattingEnabled = true;
            this.cbx_Adh.Location = new System.Drawing.Point(151, 83);
            this.cbx_Adh.Name = "cbx_Adh";
            this.cbx_Adh.Size = new System.Drawing.Size(121, 21);
            this.cbx_Adh.TabIndex = 0;
            this.cbx_Adh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(185, 341);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_nomAdh
            // 
            this.lbl_nomAdh.AutoSize = true;
            this.lbl_nomAdh.Location = new System.Drawing.Point(182, 124);
            this.lbl_nomAdh.Name = "lbl_nomAdh";
            this.lbl_nomAdh.Size = new System.Drawing.Size(27, 13);
            this.lbl_nomAdh.TabIndex = 3;
            this.lbl_nomAdh.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code Adh";
            // 
            // GestionRetours_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nomAdh);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_Adh);
            this.Name = "GestionRetours_Form";
            this.Text = "GestionRetours_Form";
            this.Load += new System.EventHandler(this.GestionRetours_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Adh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_nomAdh;
        private System.Windows.Forms.Label label2;
    }
}
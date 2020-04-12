using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM_Reg_V2
{
    public partial class GestionRetours_Form : Form
    {
        public GestionRetours_Form()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             DataRow r = Program.ds.Tables["adherents"].Rows.Find(cbx_Adh.SelectedValue);
             lbl_nomAdh.Text = r["Nomadh"].ToString();

             DataRow[] dr = Program.ds.Tables["adherents"].Select("CodeAdh=" + cbx_Adh.SelectedValue);
             dataGridView1.DataSource = dr.CopyToDataTable();
        }

        private void GestionRetours_Form_Load(object sender, EventArgs e)
        {

            cbx_Adh.ValueMember = "CodeAdh";
            cbx_Adh.DataSource = Program.ds.Tables["adherents"];
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {

        }
    }
}

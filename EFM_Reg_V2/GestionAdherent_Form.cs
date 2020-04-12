using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFM_Reg_V2
{
    public partial class GestionAdherent_Form : Form
    {
        public GestionAdherent_Form()
        {
            InitializeComponent();
        }
        gestion_videothequeEntities GVE = new gestion_videothequeEntities();
        BindingSource bs = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.DS();
            bs.DataSource = GVE.adherents.ToList();
            //bs.DataSource = GVE.adherents.Local;
            tb_CodeAdh.DataBindings.Add("text", bs, "CodeAdh", true);
            tb_NomAdh.DataBindings.Add("text", bs, "NomAdh", true);
            tb_PrenomAdh.DataBindings.Add("text", bs, "PrenomAdh", true);
            tb_rech.Visible = false;
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try {
                bs.EndEdit();
                GVE.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Premier_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btn_Precedent_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btn_Suivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btn_Dernier_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Adh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(rb_Tous.Checked==true)
            {
                dgv_Adh.DataSource = GVE.adherents.ToList();
            }
            else if(rb_nom.Checked==true)
            {
                tb_rech.Visible = false;
                DataRow[] dr = Program.ds.Tables["adherents"].Select("NomAdh='" + tb_rech.Text);
                dgv_Adh.DataSource = dr.CopyToDataTable(); 
            }
        }
    }
}

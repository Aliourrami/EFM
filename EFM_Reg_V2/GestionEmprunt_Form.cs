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
    public partial class GestionEmprunt_Form : Form
    {
        public GestionEmprunt_Form()
        {
            InitializeComponent();
        }
        //gestion_videothequeEntities GVE = new gestion_videothequeEntities();
        private void GestionEmprunt_Form_Load(object sender, EventArgs e)
        {
            Program.DS();
            cbx_Adh.ValueMember = "CodeAdh";
            //cbx_Adh.DataSource="NomAdh";
            cbx_Adh.DataSource = Program.ds.Tables["adherents"];

            cbx_Film.ValueMember = "CodeFilm";
            cbx_Film.DisplayMember = "TitOuv";
            cbx_Film.DataSource = Program.ds.Tables["adherents"];
        }

        private void cbx_Adh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRow[] dr = Program.ds.Tables["adherents"].Select("CodeAdh=" + cbx_Adh.SelectedValue);
            DGV_Adh.DataSource = dr.CopyToDataTable();
        }

        private void cbx_Film_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] dr = Program.ds.Tables["Films"].Select("CodeFilm=" + cbx_Adh.SelectedValue);
            DGV_Film.DataSource = dr.CopyToDataTable(); 
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //
            DataRow r = Program.ds.Tables["Emprunts"].NewRow();
            r["CodeAdh"] = tb_CodeAdh.Text;
            r["CodeFilm"] = tb_CodeFilm.Text;
            r["DateEmp"] = DTP_DateEmp.Value;
            r["DateRet"] = DTP_DateRet.Value;
            Program.ds.Tables["Emprunts"].Rows.Add(r);
        }
    }
}

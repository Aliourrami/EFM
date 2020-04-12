using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace EFM_Reg_V2
{
    static class Program
    {
            public static string cnx = @"data source= S2-PC8\SQLEXPRESS; database= gestion_videotheque; integrated security=true;";
            public static DataSet ds =new DataSet();
            public static SqlDataAdapter da_Adh;
            public static SqlDataAdapter da_Emp;
            public static SqlDataAdapter da_Film;





            public static void DS()
            {
                da_Adh = new SqlDataAdapter("select * from adherents", cnx);
                da_Adh.Fill(ds, "adherents");

                da_Film = new SqlDataAdapter("select * from Films", cnx);
                da_Film.Fill(ds, "Films");

                da_Emp = new SqlDataAdapter("select * from Emprunts", cnx);
                da_Emp.Fill(ds, "Emprunts");

                ds.Tables["adherents"].PrimaryKey = new DataColumn[] { ds.Tables["adherents"].Columns[0] };

                ds.Tables["Films"].PrimaryKey = new DataColumn[] { ds.Tables["Films"].Columns[0] };

                ds.Tables["Emprunts"].PrimaryKey = new DataColumn[] { ds.Tables["Emprunts"].Columns[0] };
            }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GestionEmprunt_Form());
            Application.Run(new GestionAdherent_Form());
            Application.Run(new GestionRetours_Form());
        }
    }
}

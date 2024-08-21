using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tercer_Proyecto_2Q_2024.Capa_Logica;

namespace Tercer_Proyecto_2Q_2024.Capa_Vistas
{
    public partial class candidatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM candidatos"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GDcandi.DataSource = dt;
                            GDcandi.DataBind();
                        }
                    }
                }
            }
        }
        
        protected void Boto_candysend_Click(object sender, EventArgs e)
        {
            if (CLS_met_candidatos.Agregar (Txt_cedula.Text, Txt_nombre.Text, int.Parse(Txt_partido.Text), int.Parse(Txt_edad.Text), int.Parse(Txt_plataf.Text)) > 0)
            {
                LlenarGrid();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tercer_Proyecto_2Q_2024.Capa_Datos;

namespace Tercer_Proyecto_2Q_2024.Capa_Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Validar_User(Txt_nombre.Text, Txt_email.Text, Txt_contra.Text);
        }

        protected void Validar_User(string nombre, string correo, string contra)
        {
            CLS_usuarios.nombre = nombre;
            CLS_usuarios.correo = correo;
            CLS_usuarios.contra = contra;
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT nombre, correo, contra FROM usuarios WHERE correo = '" + correo + "' " + "and contra = '" + contra + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                {
                  CLS_usuarios.nombre = registro["nombre"].ToString();
                Response.Redirect("Inicio.aspx");
                }
            else
                {
                //Txt_nombre.Text = " Usuario o contraseña incorrecto";
                }
            conexion.Close();
        }
    }
}
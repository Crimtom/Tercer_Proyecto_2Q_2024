using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tercer_Proyecto_2Q_2024.Capa_Datos;

namespace Tercer_Proyecto_2Q_2024.Capa_Logica
{
    public class CLS_met_plataformas
    {
        public static int Agregar(string plataf, string especter)
        {
            int retorno = 0;
            CLS_plataformas.plata_name = plataf;
            CLS_plataformas.posicion_espectro = especter;

            string querry = "INSERT INTO plataformas (plata_name, posicion_espectro) VALUES (@plataf, @especter)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);
                    cmd.Parameters.Add(new SqlParameter("@plataf", plataf));
                    cmd.Parameters.Add(new SqlParameter("@especter", especter));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}
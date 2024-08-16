using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tercer_Proyecto_2Q_2024.Capa_Datos;

namespace Tercer_Proyecto_2Q_2024.Capa_Logica
{
    public class CLS_met_partidos
    {
        public static int Agregar(string party)
        {
            int retorno = 0;
            CLS_partidos.nombre_partido = party;

            string querry = "INSERT INTO partidos (nombre_partido) VALUES (@party)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);
                    cmd.Parameters.Add(new SqlParameter("@party", party));
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
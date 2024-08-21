using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tercer_Proyecto_2Q_2024.Capa_Datos;

namespace Tercer_Proyecto_2Q_2024.Capa_Logica
{
    public class CLS_met_votos_amount
    {
        public static int Agregar(CLS_partidos party, int voto_conteo)
        {
            int retorno = 0;
            CLS_votos_amount.partido_id = party;
            CLS_votos_amount.canti_votos = voto_conteo;

            string querry = "INSERT INTO votos_amount (partido_id, voto_conteo) VALUES (@party, @voto_conteo)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);
                    cmd.Parameters.Add(new SqlParameter("@party", party));
                    cmd.Parameters.Add(new SqlParameter("@voto_conteo", voto_conteo));
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
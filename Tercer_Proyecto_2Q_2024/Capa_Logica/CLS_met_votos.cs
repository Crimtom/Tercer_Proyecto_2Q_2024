using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tercer_Proyecto_2Q_2024.Capa_Datos;

namespace Tercer_Proyecto_2Q_2024.Capa_Logica
{
    public class CLS_met_votos
    {
        public static int Agregar(string ced, string nombre, byte votado, int edad, int votar_candi)
        {
            int retorno = 0;
            CLS_votos.cedula = ced;
            CLS_votos.nombre = nombre;
            CLS_votos.voted = votado;
            CLS_votos.edad = edad;
            CLS_votos.voto_candid = votar_candi;

            string querry = "INSERT INTO votos (cedula, nombre, voted, edad, voto_candid) VALUES (@ced, @nombre, @votado, @edad, @votar_candi)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);
                    cmd.Parameters.Add(new SqlParameter("@ced", ced));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@votado", votado));
                    cmd.Parameters.Add(new SqlParameter("@edad", edad));
                    cmd.Parameters.Add(new SqlParameter("@votar_candi", votar_candi));
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
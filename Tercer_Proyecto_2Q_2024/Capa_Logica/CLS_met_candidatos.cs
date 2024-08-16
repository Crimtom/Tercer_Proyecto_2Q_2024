using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tercer_Proyecto_2Q_2024.Capa_Datos;

namespace Tercer_Proyecto_2Q_2024.Capa_Logica
{
    public class CLS_met_candidatos
    {
        public static int Agregar(string ced, string nombre, int partido, int age, int plataf)
        {
            int retorno = 0;
            CLS_candidatos.cedula = ced;
            CLS_candidatos.nombre = nombre;
            CLS_candidatos.partido_id = partido;
            CLS_candidatos.edad = age;
            CLS_candidatos.plataf_id = plataf;

            string querry = "INSERT INTO candidatos (cedula, nombre, partido_id, edad, plataf_id) VALUES (@ced, @nombre, @partido, @age, @plataf)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);
                    cmd.Parameters.Add(new SqlParameter("@ced", ced));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@partido", partido));
                    cmd.Parameters.Add(new SqlParameter("@age", age));
                    cmd.Parameters.Add(new SqlParameter("@plataf", plataf));
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
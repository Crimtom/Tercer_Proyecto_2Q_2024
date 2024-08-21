using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tercer_Proyecto_2Q_2024.Capa_Datos
{
    public class CLS_candidatos
    {
        public static int candi_id {  get; set; }
        public static string cedula { get; set; }
        public static string nombre { get; set; }
        public static CLS_partidos partido_id { get; set; }
        public static int edad {  get; set; }
        public static CLS_plataformas plataf_id { get; set; }
    }
}
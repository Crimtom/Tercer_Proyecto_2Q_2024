using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tercer_Proyecto_2Q_2024.Capa_Datos
{
    public class CLS_votos_amount
    {
        public static int id_va {  get; set; }
        public static CLS_partidos partido_id { get; set; }
        public static int canti_votos { get; set; }
    }
}
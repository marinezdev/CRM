using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Actividades
    {
        Data.Actividades _Actividades = new Data.Actividades();
        public List<Models.Consulta.Actividades> Actividades_Selecionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            return _Actividades.Actividades_Selecionar_FechaRegistro(actividades);
        }
        public Models.Consulta.Actividades Actividades_Selecionar_Valor(Models.Consulta.Actividades actividades)
        {
            return _Actividades.Actividades_Selecionar_Valor(actividades);
        }
        public List<Models.Consulta.Actividades> Actividades_Selecionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            return _Actividades.Actividades_Selecionar_FechaRegistro_IdUsuario(actividades);
        }
    }
}

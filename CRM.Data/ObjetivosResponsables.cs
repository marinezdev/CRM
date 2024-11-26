using CRM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class ObjetivosResponsables
    {
        ManejoDatos b = new ManejoDatos();
        public Models.ObjetivosResponsables ObjetivosResponsables_Agregar(Models.ObjetivosResponsables objetivosResponsables)
        {
            const string consulta = "ObjetivosResponsables_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", objetivosResponsables.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", objetivosResponsables.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@FacturacionRecurrente", objetivosResponsables.FacturacionRecurrente, SqlDbType.Float);
            b.AddParameter("@ProyectosNuevos", objetivosResponsables.ProyectosNuevos, SqlDbType.Float);
            b.AddParameter("@Descripcion", objetivosResponsables.Descripcion, SqlDbType.NVarChar);

            Models.ObjetivosResponsables resultado = new Models.ObjetivosResponsables();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivosResponsables>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.ObjetivosResponsables ObjetivosResponsables_Seleccionar_Id(Models.ObjetivosResponsables objetivosResponsables)
        {
            const string consulta = "ObjetivosResponsables_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", objetivosResponsables.Id, SqlDbType.Int);

            Models.ObjetivosResponsables resultado = new Models.ObjetivosResponsables();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivosResponsables>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.ObjetivosResponsables ObjetivosResponsables_Actualizar(Models.ObjetivosResponsables objetivosResponsables)
        {
            const string consulta = "ObjetivosResponsables_Actualizar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", objetivosResponsables.Id, SqlDbType.Int);
            b.AddParameter("@FacturacionRecurrente", objetivosResponsables.FacturacionRecurrente, SqlDbType.Float);
            b.AddParameter("@ProyectosNuevos", objetivosResponsables.ProyectosNuevos, SqlDbType.Float);

            Models.ObjetivosResponsables resultado = new Models.ObjetivosResponsables();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivosResponsables>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.ObjetivosResponsables> ObjetivosResponsables_Selecionar_Year()
        {
            const string consulta = "ObjetivosResponsables_Selecionar_Year";
            b.ExecuteCommandSP(consulta);

            List<Models.ObjetivosResponsables> resultado = new List<Models.ObjetivosResponsables>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.ObjetivosResponsables>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.ObjetivosResponsables> ObjetivosResponsables_Reporte_Year(int year)
        {
            const string consulta = "ObjetivosResponsables_Reporte_Year";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Year", year, SqlDbType.Int);

            List<Models.ObjetivosResponsables> resultado = new List<Models.ObjetivosResponsables>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.ObjetivosResponsables>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}

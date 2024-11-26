using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatUnidadNegocio
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatUnidadNegocio> CatUnidadNegocio_Seleccionar()
        {
            const string consulta = "CatUnidadNegocio_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatUnidadNegocio> resultado = new List<Models.CatUnidadNegocio>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatUnidadNegocio>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatUnidadNegocio CatUnidadNegocio_Agregar(Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "CatUnidadNegocio_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catUnidadNegocio.Nombre, SqlDbType.VarChar);

            Models.CatUnidadNegocio resultado = new Models.CatUnidadNegocio();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatUnidadNegocio>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}

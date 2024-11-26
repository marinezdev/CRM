using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class OportunidadProducto
    {
        ManejoDatos b = new ManejoDatos();
        
        public Models.OportunidadProducto OportunidadProducto_Agregar(Models.OportunidadProducto oportunidadProducto)
        {
            const string consulta = "OportunidadProducto_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadProducto.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdProducto", oportunidadProducto.CatProducto.Id, SqlDbType.Int);
            b.AddParameter("@IdMoneda", oportunidadProducto.CatMoneda.Id, SqlDbType.Int);
            b.AddParameter("@Item", oportunidadProducto.Item, SqlDbType.Int);
            b.AddParameter("@Valor", oportunidadProducto.Valor, SqlDbType.Float);
            b.AddParameter("@TipoCambio", oportunidadProducto.TipoCambio, SqlDbType.Float);
            b.AddParameter("@IdUsuario", oportunidadProducto.Usuario.Id, SqlDbType.Int);

            Models.OportunidadProducto resultado = new Models.OportunidadProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.OportunidadProducto> OportunidadProducto_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            const string consulta = "OportunidadProducto_Seleccionar_IdOportunidad";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.Int);

            List<Models.OportunidadProducto> resultado = new List<Models.OportunidadProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.OportunidadProducto OportunidadProducto_Eliminar(Models.OportunidadProducto oportunidadProducto)
        {
            const string consulta = "OportunidadProducto_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadProducto.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@Id", oportunidadProducto.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadProducto.Usuario.Id, SqlDbType.Int);

            Models.OportunidadProducto resultado = new Models.OportunidadProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.OportunidadProducto OportunidadProducto_Selecionar_OportunidadProducto(Models.OportunidadProducto oportunidadProducto)
        {
            const string consulta = "OportunidadProducto_Selecionar_OportunidadProducto";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadProducto.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdProducto", oportunidadProducto.CatProducto.Id, SqlDbType.Int);

            Models.OportunidadProducto resultado = new Models.OportunidadProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}

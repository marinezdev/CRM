using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class OportunidadImporte
    {
        ManejoDatos b = new ManejoDatos();

        public Models.OportunidadImporte OportunidadImporte_Agregar(Models.OportunidadImporte oportunidadImporte)
        {
            const string consulta = "OportunidadImporte_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadImporte.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdMoneda", oportunidadImporte.CatMoneda.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadImporte.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Valor", oportunidadImporte.Valor, SqlDbType.Float);
            b.AddParameter("@TipoCambio", oportunidadImporte.TipoCambio, SqlDbType.Float);
            b.AddParameter("@Obsercion", oportunidadImporte.Observacion, SqlDbType.NVarChar);

            Models.OportunidadImporte resultado = new Models.OportunidadImporte();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadImporte>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.OportunidadImporte OportunidadImporte_Eliminar(Models.OportunidadImporte oportunidadImporte)
        {
            const string consulta = "OportunidadImporte_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadImporte.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdImporte", oportunidadImporte.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadImporte.Usuario.Id, SqlDbType.Int);

            Models.OportunidadImporte resultado = new Models.OportunidadImporte();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadImporte>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.OportunidadImporte OportunidadImporte_Editar(Models.OportunidadImporte oportunidadImporte)
        {
            const string consulta = "OportunidadImporte_Editar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", oportunidadImporte.Id, SqlDbType.Int);
            b.AddParameter("@IdOportunidad", oportunidadImporte.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdMoneda", oportunidadImporte.CatMoneda.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadImporte.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Valor", oportunidadImporte.Valor, SqlDbType.Float);
            b.AddParameter("@TipoCambio", oportunidadImporte.TipoCambio, SqlDbType.Float);
            b.AddParameter("@Obsercion", oportunidadImporte.Observacion, SqlDbType.NVarChar);

            Models.OportunidadImporte resultado = new Models.OportunidadImporte();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadImporte>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.OportunidadImporte OportunidadImporte_Seleccionar_Id(Models.OportunidadImporte oportunidadImporte)
        {
            const string consulta = "OportunidadImporte_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", oportunidadImporte.Id, SqlDbType.Int);

            Models.OportunidadImporte resultado = new Models.OportunidadImporte();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadImporte>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.OportunidadImporte> OportunidadImporte_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            const string consulta = "OportunidadImporte_Seleccionar_IdOportunidad";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.Int);

            List<Models.OportunidadImporte> resultado = new List<Models.OportunidadImporte>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadImporte>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}

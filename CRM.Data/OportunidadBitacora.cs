using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class OportunidadBitacora
    { 
        ManejoDatos b = new ManejoDatos();
        public Models.OportunidadBitacora OportunidadBitacora_Agregar(Models.OportunidadBitacora oportunidadBitacora)
        {
            const string consulta = "OportunidadBitacora_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadBitacora.Oportunidad.Id, SqlDbType.NVarChar);
            b.AddParameter("@IdUsuario", oportunidadBitacora.Usuario.Id, SqlDbType.NVarChar);
            b.AddParameter("@Operacion", oportunidadBitacora.Operacion, SqlDbType.NVarChar);
            b.AddParameter("@Nota", oportunidadBitacora.Nota, SqlDbType.NVarChar);

            Models.OportunidadBitacora resultado = new Models.OportunidadBitacora();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadBitacora>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.OportunidadBitacora> OportunidadBitacora_Seleccionar(Models.Oportunidad oportunidad)
        {
            const string consulta = "OportunidadBitacora_Seleccionar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.NVarChar);

            List<Models.OportunidadBitacora> resultado = new List<Models.OportunidadBitacora>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadBitacora>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}

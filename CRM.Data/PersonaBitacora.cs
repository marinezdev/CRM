using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class PersonaBitacora
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.PersonaBitacora> PersonaBitacora_Seleccionar(Models.Contacto contacto)
        {
            const string consulta = "PersonaBitacora_Seleccionar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", contacto.Persona.Id, SqlDbType.NVarChar);

            List<Models.PersonaBitacora> resultado = new List<Models.PersonaBitacora>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.PersonaBitacora>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}

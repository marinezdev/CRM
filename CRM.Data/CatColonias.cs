﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatColonias
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatColonias> CatColonias_Seleccionar_IdPoblacion(Models.CatPoblaciones catPoblaciones)
        {
            const string consulta = "CatColonias_Seleccionar_IdPoblacion";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPolacion", catPoblaciones.Id, SqlDbType.VarChar);

            List<Models.CatColonias> resultado = new List<Models.CatColonias>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatColonias>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}

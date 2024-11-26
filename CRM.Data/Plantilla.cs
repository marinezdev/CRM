using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CRM.Data
{
    public class Plantilla
    {
        ManejoDatos b = new ManejoDatos();

        public Models.Plantilla ObtenerPlantilla(Models.Plantilla template)
        {
            const string consulta = "ObtenerPlantilla";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", template.Id, SqlDbType.Int);

            Models.Plantilla resultado = new Models.Plantilla();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Plantilla>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Plantilla Template_Save(Models.Plantilla template)
        {
            const string consulta = "Template_Save";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", template.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", template.Nombre, SqlDbType.VarChar);
            b.AddParameter("@Imagen", template.Imagen, SqlDbType.NVarChar);
            b.AddParameter("@Formato", template.Formato, SqlDbType.NVarChar);

            Models.Plantilla resultado = new Models.Plantilla();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Plantilla>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Plantilla Template_Update(Models.Plantilla template)
        {
            const string consulta = "Template_Update";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", template.Usuario.Id, SqlDbType.Int);;
            b.AddParameter("@Formato", template.Formato, SqlDbType.NVarChar);

            Models.Plantilla resultado = new Models.Plantilla();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Plantilla>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Plantilla> ListarPlantillaUsuario(Models.Plantilla template)
        {
            const string consulta = "ListarPlantillaUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", template.Usuario.Id, SqlDbType.VarChar);


            List<Models.Plantilla> resultado = new List<Models.Plantilla>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Plantilla>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public List<Models.Plantilla> ListarPlantillas()
        {
            const string consulta = "ListarPlantillas";
            b.ExecuteCommandSP(consulta);

            List<Models.Plantilla> resultado = new List<Models.Plantilla>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Plantilla>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CampaignCorreoElectronico TemplateCampingEmail(Models.CampaignCorreoElectronico campaignCorreo)
        {
            const string consulta = "TemplateCampingEmail";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", campaignCorreo.Id, SqlDbType.Int);

            Models.CampaignCorreoElectronico resultado = new Models.CampaignCorreoElectronico();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CampaignCorreoElectronico>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }



        public Models.Plantilla CampaignCorreoElectronico_Save(Models.Plantilla template)
        {
            const string consulta = "CampaignCorreoElectronico_Save";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Formato", template.Formato, SqlDbType.NVarChar);
            b.AddParameter("@IdCampaignCorreo", template.Id, SqlDbType.Int);

            Models.Plantilla resultado = new Models.Plantilla();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Plantilla>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Plantilla Template_Eliminar(Models.Plantilla template)
        {
            const string consulta = "Template_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", template.Id, SqlDbType.Int);


            Models.Plantilla resultado = new Models.Plantilla();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Plantilla>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Plantilla Template_Editar(Models.Plantilla template)
        {
            const string consulta = "Template_Editar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", template.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", template.Nombre, SqlDbType.NVarChar);

            Models.Plantilla resultado = new Models.Plantilla();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Plantilla>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }







        public Models.Plantilla Template_Save_Id(Models.Plantilla template)
        {
            const string consulta = "Template_Save_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", template.Id, SqlDbType.Int); ;
            b.AddParameter("@Formato", template.Formato, SqlDbType.NVarChar);

            Models.Plantilla resultado = new Models.Plantilla();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Plantilla>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}

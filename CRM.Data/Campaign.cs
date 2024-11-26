using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Campaign
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Campaign Campaign_Agregar(Models.CampaignUnidadNegocio campaignUnidadNegocio)
        {
            const string consulta = "Campaign_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEstatus", campaignUnidadNegocio.Campaign.CatEstatusMarketing.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", campaignUnidadNegocio.Campaign.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", campaignUnidadNegocio.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@Clave", campaignUnidadNegocio.Campaign.Clave, SqlDbType.VarChar);
            b.AddParameter("@Nombre", campaignUnidadNegocio.Campaign.Nombre, SqlDbType.VarChar);
            b.AddParameter("@FechaInicio", campaignUnidadNegocio.Campaign.FechaInicio, SqlDbType.Date);
            b.AddParameter("@FechaFin", campaignUnidadNegocio.Campaign.FechaFin, SqlDbType.Date);
            b.AddParameter("@Descripcion", campaignUnidadNegocio.Campaign.Descripcion, SqlDbType.VarChar);

            Models.Campaign resultado = new Models.Campaign();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Campaign>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Campaign EXITSCAMPINGLIST(Models.Campaign campaign)
        {
            const string consulta = "EXITSCAMPINGLIST";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", campaign.Id, SqlDbType.Int);


            Models.Campaign resultado = new Models.Campaign();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Campaign>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Campaign Campaign_Actualizar(Models.CampaignUnidadNegocio campaignUnidadNegocio)
        {
            const string consulta = "Campaign_Actualizar";
            b.ExecuteCommandSP(consulta);
            //b.AddParameter("@IdEstatus", campaignUnidadNegocio.Campaign.CatEstatusMarketing.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", campaignUnidadNegocio.Campaign.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Id", campaignUnidadNegocio.Campaign.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", campaignUnidadNegocio.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@Clave", campaignUnidadNegocio.Campaign.Clave, SqlDbType.VarChar);
            b.AddParameter("@Nombre", campaignUnidadNegocio.Campaign.Nombre, SqlDbType.VarChar);
            b.AddParameter("@FechaInicio", campaignUnidadNegocio.Campaign.FechaInicio, SqlDbType.Date);
            b.AddParameter("@FechaFin", campaignUnidadNegocio.Campaign.FechaFin, SqlDbType.Date);
            b.AddParameter("@Descripcion", campaignUnidadNegocio.Campaign.Descripcion, SqlDbType.VarChar);

            Models.Campaign resultado = new Models.Campaign();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Campaign>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Campaign> Campaign_Seleccionar()
        {
            const string consulta = "Campaign_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.Campaign> resultado = new List<Models.Campaign>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Campaign>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Insert(Models.CampaignCorreoElectronico Model)
        {
            const string consulta = "CampaignCorreoElectronico_Insert";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUser", Model.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdCampaign", Model.Campaign.Id, SqlDbType.Int);
            b.AddParameter("@IdEstatus", Model.CatEstatusMarketing.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", Model.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@Clave", Model.Clave, SqlDbType.VarChar);
            b.AddParameter("@Nombre", Model.Nombre, SqlDbType.VarChar);
            b.AddParameter("@FechaInicio", Model.FechaInicio, SqlDbType.Date);
            b.AddParameter("@FechaTermino", Model.FechaTermino, SqlDbType.Date);
            b.AddParameter("@FechaEnvio", Model.FechaEnvio, SqlDbType.DateTime);
            b.AddParameter("@Descripcion", Model.Descripcion, SqlDbType.VarChar);

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



        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Lista(Models.CampaignCorreoElectronico Model)
        {
            const string consulta = "CampaignLista_Insert";
            b.ExecuteCommandSP(consulta);
            //b.AddParameter("@IdCorreo", Model.Id, SqlDbType.Int);
            b.AddParameter("@IdLista", Model.Lista.Id, SqlDbType.Int);
            b.AddParameter("@IdUser", Model.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdCampaing", Model.Campaign.Id, SqlDbType.Int);




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



        public List<Models.CampaignCorreoElectronico> CampaignCorreoElectronico_listCorreo(Models.CampaignCorreoElectronico Model)
        {
            const string consulta = "CampaignCorreoElectronico_listCorreo";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", Model.Id, SqlDbType.Int);

            List<Models.CampaignCorreoElectronico> resultado = new List<Models.CampaignCorreoElectronico>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CampaignCorreoElectronico>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public Models.Campaign Campaign_Seleccionar_Id(Models.CampaignCorreoElectronico campaignCorreo)
        {
            const string consulta = "Campaign_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", campaignCorreo.Id, SqlDbType.Int);


            Models.Campaign resultado = new Models.Campaign();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Campaign>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }



        public List<Models.OportunidadBitacora> CampaignBitacora_Seleccionar(Models.CampaignCorreoElectronico campaignCorreo)
        {
            const string consulta = "CampaignBitacora_Seleccionar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", campaignCorreo.Id, SqlDbType.NVarChar);

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


        public Models.Campaign Campaign_ActualizarEstatus(Models.CampaignUnidadNegocio campaignUnidadNegocio)
        {
            const string consulta = "Campaign_ActualizarEstatus";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEstatus", campaignUnidadNegocio.Campaign.CatEstatusMarketing.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", campaignUnidadNegocio.Campaign.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Id", campaignUnidadNegocio.Campaign.Id, SqlDbType.Int);
            b.AddParameter("@Descripcion", campaignUnidadNegocio.Campaign.Descripcion, SqlDbType.VarChar);

            Models.Campaign resultado = new Models.Campaign();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Campaign>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Seleccionar_Id(Models.CampaignCorreoElectronico Model)
        {
            const string consulta = "CampaignCorreoElectronico_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", Model.Id, SqlDbType.Int);

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


        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Actualizar(Models.CampaignCorreoElectronico CampaignCorreoElectronico)
        {
            const string consulta = "CampaignCorreoElectronico_Actualizar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUser",CampaignCorreoElectronico.Campaign.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Id", CampaignCorreoElectronico.Id, SqlDbType.Int);
            b.AddParameter("@IdCampaign", CampaignCorreoElectronico.Campaign.Id, SqlDbType.Int);
            b.AddParameter("@IdEstatus", CampaignCorreoElectronico.CatEstatusMarketing.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", CampaignCorreoElectronico.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@Clave", CampaignCorreoElectronico.Clave, SqlDbType.VarChar);
            b.AddParameter("@Nombre", CampaignCorreoElectronico.Nombre, SqlDbType.VarChar);
            b.AddParameter("@FechaInicio", CampaignCorreoElectronico.FechaInicio, SqlDbType.Date);
            b.AddParameter("@FechaTermino", CampaignCorreoElectronico.FechaTermino, SqlDbType.Date);
            b.AddParameter("@Descripcion", CampaignCorreoElectronico.Descripcion, SqlDbType.VarChar);
            b.AddParameter("@FechaEnvio ", CampaignCorreoElectronico.FechaEnvio, SqlDbType.DateTime);



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
    }
}

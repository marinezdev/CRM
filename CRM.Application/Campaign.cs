using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Campaign
    {
        Data.Campaign _Campaign = new Data.Campaign();
        public Models.Campaign Campaign_Agregar(Models.CampaignUnidadNegocio campaignUnidadNegocio)
        {
            return _Campaign.Campaign_Agregar(campaignUnidadNegocio);
        }
        public Models.Campaign EXITSCAMPINGLIST(Models.Campaign campaign)
        {
            return _Campaign.EXITSCAMPINGLIST(campaign);
        }

        public Models.Campaign Campaign_Actualizar(Models.CampaignUnidadNegocio campaignUnidadNegocio)
        {
            return _Campaign.Campaign_Actualizar(campaignUnidadNegocio);
        }

        public Models.Campaign Campaign_ActualizarEstatus(Models.CampaignUnidadNegocio campaignUnidadNegocio)
        {
            return _Campaign.Campaign_ActualizarEstatus(campaignUnidadNegocio);
        }

        public List<Models.Campaign> Campaign_Seleccionar()
        {
            return _Campaign.Campaign_Seleccionar();
        }

        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Insert(Models.CampaignCorreoElectronico Model)
        {
            return _Campaign.CampaignCorreoElectronico_Insert(Model);
        }

        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Lista(Models.CampaignCorreoElectronico Model)
        {
            return _Campaign.CampaignCorreoElectronico_Lista(Model);
        }

        public List<Models.CampaignCorreoElectronico> CampaignCorreoElectronico_listCorreo(Models.CampaignCorreoElectronico Model)
        {
            return _Campaign.CampaignCorreoElectronico_listCorreo(Model);
        }

        public Models.Campaign Campaign_Seleccionar_Id(Models.CampaignCorreoElectronico campaignCorreo)
        {
            return _Campaign.Campaign_Seleccionar_Id(campaignCorreo);
        }


        public List<Models.OportunidadBitacora> CampaignBitacora_Seleccionar(Models.CampaignCorreoElectronico campaignCorreo)
        {
            return _Campaign.CampaignBitacora_Seleccionar(campaignCorreo);
        }







        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Seleccionar_Id(Models.CampaignCorreoElectronico Model)
        {
            return _Campaign.CampaignCorreoElectronico_Seleccionar_Id(Model);
        }



        public Models.CampaignCorreoElectronico CampaignCorreoElectronico_Actualizar(Models.CampaignCorreoElectronico CampaignCorreoElectronico)
        {
            return _Campaign.CampaignCorreoElectronico_Actualizar(CampaignCorreoElectronico);
        }

    }
}

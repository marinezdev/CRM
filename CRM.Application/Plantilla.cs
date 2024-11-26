using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Plantilla
    {
        Data.Plantilla _Template = new Data.Plantilla();
        public Models.Plantilla ObtenerPlantilla(Models.Plantilla template)
        {
            return _Template.ObtenerPlantilla(template);
        }

        public Models.Plantilla Template_Save(Models.Plantilla template)
        {
            return _Template.Template_Save(template);
        }
        public Models.Plantilla Template_Update(Models.Plantilla template)
        {
            return _Template.Template_Update(template);
        }

        public List<Models.Plantilla> ListarPlantillaUsuario(Models.Plantilla template)
        {
            return _Template.ListarPlantillaUsuario(template);
        }
        public List<Models.Plantilla> ListarPlantillas()
        {
            return _Template.ListarPlantillas();
        }

        public Models.CampaignCorreoElectronico TemplateCampingEmail(Models.CampaignCorreoElectronico campaignCorreo)
        {
            return _Template.TemplateCampingEmail(campaignCorreo);
        }


        public Models.Plantilla CampaignCorreoElectronico_Save(Models.Plantilla template)
        {
            return _Template.CampaignCorreoElectronico_Save(template);
        }

        public Models.Plantilla Template_Eliminar(Models.Plantilla template)
        {
            return _Template.Template_Eliminar(template);
        }

        public Models.Plantilla Template_Editar(Models.Plantilla template)
        {
            return _Template.Template_Editar(template);
        }






        public Models.Plantilla Template_Save_Id(Models.Plantilla template)
        {
            return _Template.Template_Save_Id(template);
        }

    }
}

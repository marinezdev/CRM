using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class SendEmail
    {
        public Contacto Contacto { get; set; }
        public CampaignCorreoElectronico CampaignCorreoElectronico { get; set; }
    }
}

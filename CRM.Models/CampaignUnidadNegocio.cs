using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class CampaignUnidadNegocio
    {
        public int Id { get; set; }
        public Campaign Campaign { get; set; }
        public CatUnidadNegocio CatUnidadNegocio { get; set; }
    }
}

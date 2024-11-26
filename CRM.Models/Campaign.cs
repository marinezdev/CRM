using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public CatEstatusMarketing CatEstatusMarketing { get; set; }
        public Usuario Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public Lista lista { get; set; }
        public DateTime FechaRegistro { get; set; }
        public CampaignUnidadNegocio CampaignUnidadNegocio { get; set; }
    }
}

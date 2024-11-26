using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class OportunidadImporte
    {
        public int Id { get; set; }
        public Oportunidad Oportunidad { get; set; }
        public CatMoneda CatMoneda { get; set; }
        public Usuario Usuario { get; set; }
        public float Valor { get; set; }
        public float TipoCambio { get; set; }
        public string Observacion { get; set; }
    }
}

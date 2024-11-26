using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class EtapaOportunidad
    {
        public CatEtapaOportunidad CatEtapaOportunidad {get; set;}
        public int Total { get; set; }
        public float Suma { get; set; }
    }
}

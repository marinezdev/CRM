using System;
namespace CRM.Models
{
	public class CampaignCorreoElectronico
	{
        public int Id { get; set; }
        public Campaign Campaign { get; set; }
        public CatEstatusMarketing CatEstatusMarketing { get; set; }
        public CatUnidadNegocio CatUnidadNegocio { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Descripcion { get; set; }
        public string Formato { get; set; }
        public string Imagen { get; set; }
        public Usuario Usuario { get; set; }
        public Lista Lista { get; set; }
        public int Activo { get; set; }
    }
}


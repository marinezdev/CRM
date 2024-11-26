using System;
namespace CRM.Models
{
	public class Plantilla
	{
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Formato { get; set; }
        public string Imagen { get; set; }
        public Usuario Usuario { get; set; }
        public Campaign Campaign { get; set; }
        public Lista Lista { get; set; }    
        public int Activo { get; set; }
    }
}


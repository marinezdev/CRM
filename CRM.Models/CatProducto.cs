using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class CatProducto
    {
        public CatClasificacionProducto CatClasificacionProducto { get; set; }
        public ProductoImagen ProductoImagen { get; set; }
        public Usuario Usuario { get; set; }
        public int Id
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }
        public string SKU { get; set; }
        public string Descripcion { get; set; }
     }
}

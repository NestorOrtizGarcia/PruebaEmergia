using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{ 
    public partial class Producto
    {
        public Producto()
        {
            ProductoCiclo = new HashSet<ProductoCiclo>();
        }

        public int Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Detalle { get; set; }
        public string Imagen { get; set; }
        public int? NumeroCategoria { get; set; }

        public virtual Categoria NumeroCategoriaNavigation { get; set; }
        public virtual ICollection<ProductoCiclo> ProductoCiclo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class ProductoCiclo
    {
        public ProductoCiclo()
        {
            Detalle = new HashSet<Detalle>();
        }

        public int IdproductoCiclo { get; set; }
        public double? Precio { get; set; }
        public double? PrecioPromocional { get; set; }
        public double? ComisionVendedor { get; set; }
        public double? Cannon { get; set; }
        public int? NumCiclo { get; set; }
        public int? NumProducto { get; set; }

        public virtual Ciclo NumCicloNavigation { get; set; }
        public virtual Producto NumProductoNavigation { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Factura
    {
        public Factura()
        {
            Detalle = new HashSet<Detalle>();
        }

        public int Idfactura { get; set; }
        public DateTime? Fecha { get; set; }
        public int? NumCliente { get; set; }
        public int? NumVendedor { get; set; }

        public virtual Cliente NumClienteNavigation { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}

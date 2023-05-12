using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Detalle
    {
        public int IdDetalle { get; set; }
        public int? Cantidad { get; set; }
        public double? Precio { get; set; }
        public int? NumProductoCiclo { get; set; }
        public int? NumFactura { get; set; }

        public virtual Factura NumFacturaNavigation { get; set; }
        public virtual ProductoCiclo NumProductoCicloNavigation { get; set; }
    }
}

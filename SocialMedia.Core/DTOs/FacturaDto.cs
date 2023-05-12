using System;

namespace SocialMedia.Core.DTOs
{
    public class FacturaDto
    {
        public int Idfactura { get; set; }
        public DateTime? Fecha { get; set; }
        public int? NumCliente { get; set; }
        public int? NumVendedor { get; set; }
    }
}

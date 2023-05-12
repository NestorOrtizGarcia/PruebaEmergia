using SocialMedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IFacturaRepository
    {
        Task<IEnumerable<Factura>> GetFacturas();
        Task<Factura> GetFactura(int id);
        Task InsertFactura(Factura factura);
        Task<bool> UpdateFactura(Factura factura);
        Task<bool> DeleteFactura(int id);
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {

        private readonly IFacturaRepository _facturaRepository;
        private readonly IMapper _mapper;
        public FacturaController(IFacturaRepository facturaRepository,IMapper mapper)
        {
            _facturaRepository = facturaRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetFactura()
        {
            var facturas = await _facturaRepository.GetFacturas();
            var facturasDtos = _mapper.Map<IEnumerable<FacturaDto>>(facturas);
            return Ok(facturasDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFactura(int id)
        {
            var factura = await _facturaRepository.GetFactura(id);
            var facturaDto = _mapper.Map<FacturaDto>(factura);
            return Ok(facturaDto);
        }
        [HttpPost]
        public async Task<IActionResult> InsertFactura(FacturaDto facturaDto)
        {
            var factura = _mapper.Map<Factura>(facturaDto);
            await _facturaRepository.InsertFactura(factura);
            return Ok(factura);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFactura(FacturaDto facturaDto)
        {
            var factura = _mapper.Map<Factura>(facturaDto);
            var result = await _facturaRepository.UpdateFactura(factura);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFactura(int id)
        {
            await _facturaRepository.DeleteFactura(id);
            return Ok(true);
        }


    }
}

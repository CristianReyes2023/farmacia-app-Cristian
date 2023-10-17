
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FacturaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FacturaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<FacturaDto>>> Get()
        {
            var factura = await _unitOfWork.Facturas.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<FacturaDto>>(factura); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<Factura>> Post(FacturaDto facturaDto)
        {
            var factura = _mapper.Map<Factura>(facturaDto);
            _unitOfWork.Facturas.Add(factura);
            await _unitOfWork.SaveAsync();
            if (factura == null)
            {
                return BadRequest();
            }
            facturaDto.Id = factura.Id;
            return CreatedAtAction(nameof(Post), new { id = facturaDto.Id }, facturaDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FacturaDto>> Put(int id, [FromBody] FacturaDto facturaDto)
        {
            if(facturaDto == null)
                return NotFound();
            if(facturaDto.Id == 0)
            {
                facturaDto.Id = id;
            } 
            if(facturaDto.Id != id)
            {
                return BadRequest();
            }
            var facturas = _mapper.Map<Factura>(facturaDto);
            _unitOfWork.Facturas.Update(facturas);
            await _unitOfWork.SaveAsync();
            return facturaDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var factura = await _unitOfWork.Facturas.GetByIdAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            _unitOfWork.Facturas.Remove(factura);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FacturaDto>> Get(int id)
        {
            var factura = await _unitOfWork.Facturas.GetByIdAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            return _mapper.Map<FacturaDto>(factura);
        }
    }

}

using System.Reflection.Metadata.Ecma335;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DetalleMovInventarioController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetalleMovInventarioController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetalleMovInventarioDto>>> Get()
        {
            var detallemov = await _unitOfWork.DetalleMovInventarios.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<DetalleMovInventarioDto>>(detallemov); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<DetalleMovInventario>> Post(DetalleMovInventarioDto detallemovDto)
        {
            var detallemov = _mapper.Map<DetalleMovInventario>(detallemovDto);
            _unitOfWork.DetalleMovInventarios.Add(detallemov);
            await _unitOfWork.SaveAsync();
            if (detallemov == null)
            {
                return BadRequest();
            }
            detallemovDto.Id = detallemov.Id;
            return CreatedAtAction(nameof(Post), new { id = detallemovDto.Id }, detallemovDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleMovInventarioDto>> Put(int id, [FromBody] DetalleMovInventarioDto detallemovDto)
        {
            if(detallemovDto == null)
                return NotFound();
            if(detallemovDto.Id == 0)
            {
                detallemovDto.Id = id;
            } 
            if(detallemovDto.Id != id)
            {
                return BadRequest();
            }
            var detallemov = _mapper.Map<DetalleMovInventario>(detallemovDto);
            _unitOfWork.DetalleMovInventarios.Update(detallemov);
            await _unitOfWork.SaveAsync();
            return detallemovDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var detallemov = await _unitOfWork.DetalleMovInventarios.GetByIdAsync(id);
            if (detallemov == null)
            {
                return NotFound();
            }
            _unitOfWork.DetalleMovInventarios.Remove(detallemov);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleMovInventarioDto>> Get(int Id)
        {
            var detallemov = await _unitOfWork.DetalleMovInventarios.GetByIdAsync(Id);
            if (detallemov == null)
            {
                return NotFound();
            }
            return _mapper.Map<DetalleMovInventarioDto>(detallemov);
        }
    }
}
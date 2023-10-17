
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MovimientoInventarioController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MovimientoInventarioController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MovimientoInventarioDto>>> Get()
        {
            var movinventario = await _unitOfWork.MovimientoInventarios.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<MovimientoInventarioDto>>(movinventario); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<MovimientoInventario>> Post(MovimientoInventarioDto movinventarioDto)
        {
            var movinventario = _mapper.Map<MovimientoInventario>(movinventarioDto);
            _unitOfWork.MovimientoInventarios.Add(movinventario);
            await _unitOfWork.SaveAsync();
            if (movinventario == null)
            {
                return BadRequest();
            }
            movinventarioDto.Id = movinventario.Id;
            return CreatedAtAction(nameof(Post), new { id = movinventarioDto.Id }, movinventarioDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MovimientoInventarioDto>> Put(string id, [FromBody] MovimientoInventarioDto movinventarioDto)
        {
            if(movinventarioDto == null)
                return NotFound();
            if(movinventarioDto.Id == null)
            {
                movinventarioDto.Id = id;
            } 
            if(movinventarioDto.Id != id)
            {
                return BadRequest();
            }
            var movinventario = _mapper.Map<MovimientoInventario>(movinventarioDto);
            _unitOfWork.MovimientoInventarios.Update(movinventario);
            await _unitOfWork.SaveAsync();
            return movinventarioDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id)
        {
            var movinventario = await _unitOfWork.MovimientoInventarios.GetByIdAsync(id);
            if (movinventario == null)
            {
                return NotFound();
            }
            _unitOfWork.MovimientoInventarios.Remove(movinventario);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MovimientoInventarioDto>> Get(string id)
        {
            var movinventario = await _unitOfWork.MovimientoInventarios.GetByIdAsync(id);
            if (movinventario == null)
            {
                return NotFound();
            }
            return _mapper.Map<MovimientoInventarioDto>(movinventario);
        }
    }

}

using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TipoMovInventarioController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoMovInventarioController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoMovInventarioDto>>> Get()
        {
            var tipomov = await _unitOfWork.TipoMovInventarios.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<TipoMovInventarioDto>>(tipomov); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<TipoMovInventario>> Post(TipoMovInventarioDto tipomovDto)
        {
            var tipomov = _mapper.Map<TipoMovInventario>(tipomovDto);
            _unitOfWork.TipoMovInventarios.Add(tipomov);
            await _unitOfWork.SaveAsync();
            if (tipomov == null)
            {
                return BadRequest();
            }
            tipomovDto.Id = tipomov.Id;
            return CreatedAtAction(nameof(Post), new { id = tipomovDto.Id }, tipomovDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoMovInventarioDto>> Put(int id, [FromBody] TipoMovInventarioDto tipomovDto)
        {
            if(tipomovDto == null)
                return NotFound();
            if(tipomovDto.Id == 0)
            {
                tipomovDto.Id = id;
            } 
            if(tipomovDto.Id != id)
            {
                return BadRequest();
            }
            var tipomov = _mapper.Map<TipoMovInventario>(tipomovDto);
            _unitOfWork.TipoMovInventarios.Update(tipomov);
            await _unitOfWork.SaveAsync();
            return tipomovDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var tipomov = await _unitOfWork.TipoMovInventarios.GetByIdAsync(id);
            if (tipomov == null)
            {
                return NotFound();
            }
            _unitOfWork.TipoMovInventarios.Remove(tipomov);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoMovInventarioDto>> Get(int Id)
        {
            var tipomov = await _unitOfWork.TipoMovInventarios.GetByIdAsync(Id);
            if (tipomov == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoMovInventarioDto>(tipomov);
        }
    }

}
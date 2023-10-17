
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TipoContactoController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoContactoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoContactoDto>>> Get()
        {
            var tipocontacto = await _unitOfWork.TipoContactos.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<TipoContactoDto>>(tipocontacto); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<TipoContacto>> Post(TipoContactoDto tipocontactoDto)
        {
            var tipocontacto = _mapper.Map<TipoContacto>(tipocontactoDto);
            _unitOfWork.TipoContactos.Add(tipocontacto);
            await _unitOfWork.SaveAsync();
            if (tipocontacto == null)
            {
                return BadRequest();
            }
            tipocontactoDto.Id = tipocontacto.Id;
            return CreatedAtAction(nameof(Post), new { id = tipocontactoDto.Id }, tipocontactoDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoContactoDto>> Put(int id, [FromBody] TipoContactoDto tipocontactoDto)
        {
            if(tipocontactoDto == null)
                return NotFound();
            if(tipocontactoDto.Id == 0)
            {
                tipocontactoDto.Id = id;
            } 
            if(tipocontactoDto.Id != id)
            {
                return BadRequest();
            }
            var tipocontacto = _mapper.Map<TipoContacto>(tipocontactoDto);
            _unitOfWork.TipoContactos.Update(tipocontacto);
            await _unitOfWork.SaveAsync();
            return tipocontactoDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var tipocontacto = await _unitOfWork.TipoContactos.GetByIdAsync(id);
            if (tipocontacto == null)
            {
                return NotFound();
            }
            _unitOfWork.TipoContactos.Remove(tipocontacto);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoContactoDto>> Get(int id)
        {
            var tipocontacto = await _unitOfWork.TipoContactos.GetByIdAsync(id);
            if (tipocontacto == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoContactoDto>(tipocontacto);
        }
    }

}
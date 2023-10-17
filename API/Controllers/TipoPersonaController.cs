
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TipoPersonaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoPersonaDto>>> Get()
        {
            var tipopersona = await _unitOfWork.TipoPersonas.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<TipoPersonaDto>>(tipopersona); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<TipoPersona>> Post(TipoPersonaDto tipopersonaDto)
        {
            var tipopersona = _mapper.Map<TipoPersona>(tipopersonaDto);
            _unitOfWork.TipoPersonas.Add(tipopersona);
            await _unitOfWork.SaveAsync();
            if (tipopersona == null)
            {
                return BadRequest();
            }
            tipopersonaDto.Id = tipopersona.Id;
            return CreatedAtAction(nameof(Post), new { id = tipopersonaDto.Id }, tipopersonaDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoPersonaDto>> Put(int id, [FromBody] TipoPersonaDto tipopersonaDto)
        {
            if(tipopersonaDto == null)
                return NotFound();
            if(tipopersonaDto.Id == 0)
            {
                tipopersonaDto.Id = id;
            } 
            if(tipopersonaDto.Id != id)
            {
                return BadRequest();
            }
            var tipopersona = _mapper.Map<TipoPersona>(tipopersonaDto);
            _unitOfWork.TipoPersonas.Update(tipopersona);
            await _unitOfWork.SaveAsync();
            return tipopersonaDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var tipopersona = await _unitOfWork.TipoPersonas.GetByIdAsync(id);
            if (tipopersona == null)
            {
                return NotFound();
            }
            _unitOfWork.TipoPersonas.Remove(tipopersona);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoPersonaDto>> Get(int Id)
        {
            var tipopersona = await _unitOfWork.TipoPersonas.GetByIdAsync(Id);
            if (tipopersona == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoPersonaDto>(tipopersona);
        }
    }

}
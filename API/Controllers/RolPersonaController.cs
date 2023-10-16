
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RolPersonaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RolPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<RolPersonaDto>>> Get()
        {
            var rolpersona = await _unitOfWork.RolPersonas.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<RolPersonaDto>>(rolpersona); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<RolPersona>> Post(RolPersonaDto rolpersonaDto)
        {
            var rolpersona = _mapper.Map<RolPersona>(rolpersonaDto);
            _unitOfWork.RolPersonas.Add(rolpersona);
            await _unitOfWork.SaveAsync();
            if (rolpersona == null)
            {
                return BadRequest();
            }
            rolpersonaDto.Id = rolpersona.Id;
            return CreatedAtAction(nameof(Post), new { id = rolpersonaDto.Id }, rolpersonaDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RolPersonaDto>> Put(int id, [FromBody] RolPersonaDto rolpersonaDto)
        {
            if(rolpersonaDto == null)
                return NotFound();
            if(rolpersonaDto.Id == 0)
            {
                rolpersonaDto.Id = id;
            } 
            if(rolpersonaDto.Id != id)
            {
                return BadRequest();
            }
            var rolpersona = _mapper.Map<RolPersona>(rolpersonaDto);
            _unitOfWork.RolPersonas.Update(rolpersona);
            await _unitOfWork.SaveAsync();
            return rolpersonaDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var rolpersona = await _unitOfWork.RolPersonas.GetByIdAsync(id);
            if (rolpersona == null)
            {
                return NotFound();
            }
            _unitOfWork.RolPersonas.Remove(rolpersona);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RolPersonaDto>> Get(int Id)
        {
            var rolpersona = await _unitOfWork.RolPersonas.GetByIdAsync(Id);
            if (rolpersona == null)
            {
                return NotFound();
            }
            return _mapper.Map<RolPersonaDto>(rolpersona);
        }
    }

}
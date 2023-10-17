
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PersonaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> Get()
        {
            var persona = await _unitOfWork.Personas.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<PersonaDto>>(persona); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<Persona>> Post(PersonaDto personaDto)
        {
            var persona = _mapper.Map<Persona>(personaDto);
            _unitOfWork.Personas.Add(persona);
            await _unitOfWork.SaveAsync();
            if (persona == null)
            {
                return BadRequest();
            }
            personaDto.Id = persona.Id;
            return CreatedAtAction(nameof(Post), new { id = personaDto.Id }, personaDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PersonaDto>> Put(string id, [FromBody] PersonaDto personaDto)
        {
            if(personaDto == null)
                return NotFound();
            if(personaDto.Id == null)
            {
                personaDto.Id = id;
            } 
            if(personaDto.Id != id)
            {
                return BadRequest();
            }
            var personas = _mapper.Map<Persona>(personaDto);
            _unitOfWork.Personas.Update(personas);
            await _unitOfWork.SaveAsync();
            return personaDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id)
        {
            var persona = await _unitOfWork.Personas.GetByIdAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            _unitOfWork.Personas.Remove(persona);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PersonaDto>> Get(string id)
        {
            var persona = await _unitOfWork.Personas.GetByIdAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return _mapper.Map<PersonaDto>(persona);
        }
    }

}
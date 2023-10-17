
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ContactoPersonaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactoPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ContactoPersonaDto>>> Get()
        {
            var contactop = await _unitOfWork.ContactoPersonas.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<ContactoPersonaDto>>(contactop); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<ContactoPersona>> Post(ContactoPersonaDto contactopDto)
        {
            var contactop = _mapper.Map<ContactoPersona>(contactopDto);
            _unitOfWork.ContactoPersonas.Add(contactop);
            await _unitOfWork.SaveAsync();
            if (contactop == null)
            {
                return BadRequest();
            }
            contactopDto.Id = contactop.Id;
            return CreatedAtAction(nameof(Post), new { id = contactopDto.Id }, contactopDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ContactoPersonaDto>> Put(int id, [FromBody] ContactoPersonaDto contactopDto)
        {
            if(contactopDto == null)
                return NotFound();
            if(contactopDto.Id == 0)
            {
                contactopDto.Id = id;
            } 
            if(contactopDto.Id != id)
            {
                return BadRequest();
            }
            var contactopes = _mapper.Map<ContactoPersona>(contactopDto);
            _unitOfWork.ContactoPersonas.Update(contactopes);
            await _unitOfWork.SaveAsync();
            return contactopDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var contactop = await _unitOfWork.ContactoPersonas.GetByIdAsync(id);
            if (contactop == null)
            {
                return NotFound();
            }
            _unitOfWork.ContactoPersonas.Remove(contactop);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ContactoPersonaDto>> Get(int Id)
        {
            var contactop = await _unitOfWork.ContactoPersonas.GetByIdAsync(Id);
            if (contactop == null)
            {
                return NotFound();
            }
            return _mapper.Map<ContactoPersonaDto>(contactop);
        }
    }

}
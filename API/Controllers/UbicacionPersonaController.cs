
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UbicacionPersonaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UbicacionPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UbicacionPersonaDto>>> Get()
        {
            var ubipersona = await _unitOfWork.UbicacionPersonas.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<UbicacionPersonaDto>>(ubipersona); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<UbicacionPersona>> Post(UbicacionPersonaDto ubipersonaDto)
        {
            var ubipersona = _mapper.Map<UbicacionPersona>(ubipersonaDto);
            _unitOfWork.UbicacionPersonas.Add(ubipersona);
            await _unitOfWork.SaveAsync();
            if (ubipersona == null)
            {
                return BadRequest();
            }
            ubipersonaDto.Id = ubipersona.Id;
            return CreatedAtAction(nameof(Post), new { id = ubipersonaDto.Id }, ubipersonaDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UbicacionPersonaDto>> Put(int id, [FromBody] UbicacionPersonaDto ubipersonaDto)
        {
            if(ubipersonaDto == null)
                return NotFound();
            if(ubipersonaDto.Id == 0)
            {
                ubipersonaDto.Id = id;
            } 
            if(ubipersonaDto.Id != id)
            {
                return BadRequest();
            }
            var ubipersona = _mapper.Map<UbicacionPersona>(ubipersonaDto);
            _unitOfWork.UbicacionPersonas.Update(ubipersona);
            await _unitOfWork.SaveAsync();
            return ubipersonaDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var ubipersona = await _unitOfWork.UbicacionPersonas.GetByIdAsync(id);
            if (ubipersona == null)
            {
                return NotFound();
            }
            _unitOfWork.UbicacionPersonas.Remove(ubipersona);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UbicacionPersonaDto>> Get(int id)
        {
            var ubipersona = await _unitOfWork.UbicacionPersonas.GetByIdAsync(id);
            if (ubipersona == null)
            {
                return NotFound();
            }
            return _mapper.Map<UbicacionPersonaDto>(ubipersona);
        }
    }

}
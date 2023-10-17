
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PresentacionController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PresentacionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PresentacionDto>>> Get()
        {
            var presentacion = await _unitOfWork.Presentaciones.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<PresentacionDto>>(presentacion); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<Presentacion>> Post(PresentacionDto presentacionDto)
        {
            var presentacion = _mapper.Map<Presentacion>(presentacionDto);
            _unitOfWork.Presentaciones.Add(presentacion);
            await _unitOfWork.SaveAsync();
            if (presentacion == null)
            {
                return BadRequest();
            }
            presentacionDto.Id = presentacion.Id;
            return CreatedAtAction(nameof(Post), new { id = presentacionDto.Id }, presentacionDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PresentacionDto>> Put(int id, [FromBody] PresentacionDto presentacionDto)
        {
            if(presentacionDto == null)
                return NotFound();
            if(presentacionDto.Id == 0)
            {
                presentacionDto.Id = id;
            } 
            if(presentacionDto.Id != id)
            {
                return BadRequest();
            }
            var presentacion = _mapper.Map<Presentacion>(presentacionDto);
            _unitOfWork.Presentaciones.Update(presentacion);
            await _unitOfWork.SaveAsync();
            return presentacionDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var presentacion = await _unitOfWork.Presentaciones.GetByIdAsync(id);
            if (presentacion == null)
            {
                return NotFound();
            }
            _unitOfWork.Presentaciones.Remove(presentacion);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PresentacionDto>> Get(int Id)
        {
            var presentacion = await _unitOfWork.Presentaciones.GetByIdAsync(Id);
            if (presentacion == null)
            {
                return NotFound();
            }
            return _mapper.Map<PresentacionDto>(presentacion);
        }
    }

}
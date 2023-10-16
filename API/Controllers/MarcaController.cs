
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MarcaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MarcaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MarcaDto>>> Get()
        {
            var marca = await _unitOfWork.Marcas.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<MarcaDto>>(marca); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<Marca>> Post(MarcaDto marcaDto)
        {
            var marca = _mapper.Map<Marca>(marcaDto);
            _unitOfWork.Marcas.Add(marca);
            await _unitOfWork.SaveAsync();
            if (marca == null)
            {
                return BadRequest();
            }
            marcaDto.Id = marca.Id;
            return CreatedAtAction(nameof(Post), new { id = marcaDto.Id }, marcaDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MarcaDto>> Put(int id, [FromBody] MarcaDto marcaDto)
        {
            if(marcaDto == null)
                return NotFound();
            if(marcaDto.Id == 0)
            {
                marcaDto.Id = id;
            } 
            if(marcaDto.Id != id)
            {
                return BadRequest();
            }
            var marca = _mapper.Map<Marca>(marcaDto);
            _unitOfWork.Marcas.Update(marca);
            await _unitOfWork.SaveAsync();
            return marcaDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var marca = await _unitOfWork.Marcas.GetByIdAsync(id);
            if (marca == null)
            {
                return NotFound();
            }
            _unitOfWork.Marcas.Remove(marca);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MarcaDto>> Get(int Id)
        {
            var marca = await _unitOfWork.Marcas.GetByIdAsync(Id);
            if (marca == null)
            {
                return NotFound();
            }
            return _mapper.Map<MarcaDto>(marca);
        }
    }

}
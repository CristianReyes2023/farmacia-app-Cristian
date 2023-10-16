
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class InventarioController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InventarioController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<InventarioDto>>> Get()
        {
            var inventario = await _unitOfWork.Inventarios.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<InventarioDto>>(inventario); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<Inventario>> Post(InventarioDto inventarioDto)
        {
            var inventario = _mapper.Map<Inventario>(inventarioDto);
            _unitOfWork.Inventarios.Add(inventario);
            await _unitOfWork.SaveAsync();
            if (inventario == null)
            {
                return BadRequest();
            }
            inventarioDto.Id = inventario.Id;
            return CreatedAtAction(nameof(Post), new { id = inventarioDto.Id }, inventarioDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InventarioDto>> Put(string id, [FromBody] InventarioDto inventarioDto)
        {
            if(inventarioDto == null)
                return NotFound();
            if(inventarioDto.Id == null)
            {
                inventarioDto.Id = id;
            } 
            if(inventarioDto.Id != id)
            {
                return BadRequest();
            }
            var inventario = _mapper.Map<Inventario>(inventarioDto);
            _unitOfWork.Inventarios.Update(inventario);
            await _unitOfWork.SaveAsync();
            return inventarioDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id)
        {
            var inventario = await _unitOfWork.Inventarios.GetByIdAsync(id);
            if (inventario == null)
            {
                return NotFound();
            }
            _unitOfWork.Inventarios.Remove(inventario);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InventarioDto>> Get(string Id)
        {
            var inventario = await _unitOfWork.Inventarios.GetByIdAsync(Id);
            if (inventario == null)
            {
                return NotFound();
            }
            return _mapper.Map<InventarioDto>(inventario);
        }
    }

}
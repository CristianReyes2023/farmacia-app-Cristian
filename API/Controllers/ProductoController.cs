
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductoController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> Get()
        {
            var producto = await _unitOfWork.Productos.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<ProductoDto>>(producto); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<Producto>> Post(ProductoDto productoDto)
        {
            var producto = _mapper.Map<Producto>(productoDto);
            _unitOfWork.Productos.Add(producto);
            await _unitOfWork.SaveAsync();
            if (producto == null)
            {
                return BadRequest();
            }
            productoDto.Id = producto.Id;
            return CreatedAtAction(nameof(Post), new { id = productoDto.Id }, productoDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductoDto>> Put(int id, [FromBody] ProductoDto productoDto)
        {
            if(productoDto == null)
                return NotFound();
            if(productoDto.Id == 0)
            {
                productoDto.Id = id;
            } 
            if(productoDto.Id != id)
            {
                return BadRequest();
            }
            var producto = _mapper.Map<Producto>(productoDto);
            _unitOfWork.Productos.Update(producto);
            await _unitOfWork.SaveAsync();
            return productoDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _unitOfWork.Productos.GetByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            _unitOfWork.Productos.Remove(producto);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductoDto>> Get(int Id)
        {
            var producto = await _unitOfWork.Productos.GetByIdAsync(Id);
            if (producto == null)
            {
                return NotFound();
            }
            return _mapper.Map<ProductoDto>(producto);
        }
    }

}
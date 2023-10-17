
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FormaPagoController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FormaPagoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<FormaPagoDto>>> Get()
        {
            var formapago = await _unitOfWork.FormaPagos.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<FormaPagoDto>>(formapago); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<FormaPago>> Post(FormaPagoDto formapagoDto)
        {
            var formapago = _mapper.Map<FormaPago>(formapagoDto);
            _unitOfWork.FormaPagos.Add(formapago);
            await _unitOfWork.SaveAsync();
            if (formapago == null)
            {
                return BadRequest();
            }
            formapagoDto.Id = formapago.Id;
            return CreatedAtAction(nameof(Post), new { id = formapagoDto.Id }, formapagoDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FormaPagoDto>> Put(int id, [FromBody] FormaPagoDto formapagoDto)
        {
            if(formapagoDto == null)
                return NotFound();
            if(formapagoDto.Id == 0)
            {
                formapagoDto.Id = id;
            } 
            if(formapagoDto.Id != id)
            {
                return BadRequest();
            }
            var formapago = _mapper.Map<FormaPago>(formapagoDto);
            _unitOfWork.FormaPagos.Update(formapago);
            await _unitOfWork.SaveAsync();
            return formapagoDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var formapago = await _unitOfWork.FormaPagos.GetByIdAsync(id);
            if (formapago == null)
            {
                return NotFound();
            }
            _unitOfWork.FormaPagos.Remove(formapago);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FormaPagoDto>> Get(int Id)
        {
            var formapago = await _unitOfWork.FormaPagos.GetByIdAsync(Id);
            if (formapago == null)
            {
                return NotFound();
            }
            return _mapper.Map<FormaPagoDto>(formapago);
        }
    }

}
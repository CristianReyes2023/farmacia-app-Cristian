
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TipoDocumentoController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoDocumentoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoDocumentoDto>>> Get()
        {
            var tipodocumento = await _unitOfWork.TipoDocumentos.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<TipoDocumentoDto>>(tipodocumento); 
        }
        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  
        public async Task<ActionResult<TipoDocumento>> Post(TipoDocumentoDto tipodocumentoDto)
        {
            var tipodocumento = _mapper.Map<TipoDocumento>(tipodocumentoDto);
            _unitOfWork.TipoDocumentos.Add(tipodocumento);
            await _unitOfWork.SaveAsync();
            if (tipodocumento == null)
            {
                return BadRequest();
            }
            tipodocumentoDto.Id = tipodocumento.Id;
            return CreatedAtAction(nameof(Post), new { id = tipodocumentoDto.Id }, tipodocumentoDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoDocumentoDto>> Put(int id, [FromBody] TipoDocumentoDto tipodocumentoDto)
        {
            if(tipodocumentoDto == null)
                return NotFound();
            if(tipodocumentoDto.Id == 0)
            {
                tipodocumentoDto.Id = id;
            } 
            if(tipodocumentoDto.Id != id)
            {
                return BadRequest();
            }
            var tipodocumento = _mapper.Map<TipoDocumento>(tipodocumentoDto);
            _unitOfWork.TipoDocumentos.Update(tipodocumento);
            await _unitOfWork.SaveAsync();
            return tipodocumentoDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var tipodocumento = await _unitOfWork.TipoDocumentos.GetByIdAsync(id);
            if (tipodocumento == null)
            {
                return NotFound();
            }
            _unitOfWork.TipoDocumentos.Remove(tipodocumento);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoDocumentoDto>> Get(int id)
        {
            var tipodocumento = await _unitOfWork.TipoDocumentos.GetByIdAsync(id);
            if (tipodocumento == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoDocumentoDto>(tipodocumento);
        }
    }

}
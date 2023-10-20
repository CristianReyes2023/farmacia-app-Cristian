using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class BookCategoryController : BaseControllerApi
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BookCategoryController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<BookCategoryDto>>> Get()
    {
        var results = await _unitOfWork.BookCategories.GetAllAsync();
        return _mapper.Map<List<BookCategoryDto>>(results);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<BookCategoryDto>> Get(int idBook, int idCategory)
    {
        var result = await _unitOfWork.BookCategories.GetByIdAsync(idBook, idCategory);
        if (result == null)
        {
            return NotFound();
        }
        return _mapper.Map<BookCategoryDto>(result);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BookCategoryDto>> Post(BookCategoryDto bookCategoryDto)
    {
        var bookCategory = _mapper.Map<BookCategory>(bookCategoryDto);
        _unitOfWork.BookCategories.Add(bookCategory);
        await _unitOfWork.SaveAsync();

        if (bookCategory == null)
        {
            return BadRequest();
        }

        bookCategoryDto.IdBookFk = bookCategory.IdBookFk;
        bookCategoryDto.IdCategoryFk = bookCategory.IdCategoryFk;
        return CreatedAtAction(nameof(Post), new { idBook = bookCategoryDto.IdBookFk, idCategory = bookCategoryDto.IdCategoryFk }, bookCategoryDto);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int idBook, int idCategory)
    {
        var result = await _unitOfWork.BookCategories.GetByIdAsync(idBook, idCategory);
        if (result == null)
        {
            return NotFound();
        }
        _unitOfWork.BookCategories.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}

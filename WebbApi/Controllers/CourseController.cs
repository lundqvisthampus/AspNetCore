using Infrastructures.Dto;
using Infrastructures.Models;
using Infrastructures.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebbApi.Filters;

namespace WebbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[UseApiKey]
public class CourseController(CourseManager courseManager) : ControllerBase
{
    private readonly CourseManager _courseManager = courseManager;

    #region CREATE
    [HttpPost]
    public async Task<IActionResult> Create(CourseDto dto)
    {
        if (ModelState.IsValid)
        {
            var result = await _courseManager.GetOneWithTitleAsync(dto.Title);
            if (result == null)
            {
                try
                {
                    var created = await _courseManager.CreateAsync(dto);
                    if (created != null)
                    {
                        return Created("", null);
                    }
                }
                catch
                {
                    return Problem("Unable to create course.");
                }
            }
            else
            {
                return Conflict("Course already exists.");
            }
        }

        return BadRequest();
    }
    #endregion


    #region READ
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var courses = await _courseManager.GetAll();
        if (courses.Any())
        {
            return Ok(courses);
        }

        return NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(int id)
    {
        var course = await _courseManager.GetOneAsync(id);
        if (course != null)
        {
            return Ok(course);
        }

        return NotFound();
    }
    #endregion


    #region UPDATE
    [HttpPut]
    public async Task<IActionResult> UpdateOne(CourseDto dto, int id)
    {
        var exists = await _courseManager.GetOneAsync(id);
        if (exists != null)
        {
            var result = await _courseManager.UpdateAsync(dto, id);
            if (result)
            {
                return Ok();
            }
            return Problem();
        }
        else
        {
            return NotFound();
        }
    }
    #endregion


    #region DELETE
    [HttpDelete]
    public async Task<IActionResult> DeleteOne(int id)
    {
        var exists = await _courseManager.GetOneAsync(id);
        if (exists != null)
        {
            var result = await _courseManager.DeleteAsync(id);
            if (result)
            {
                return Ok();
            }
            return Problem();
        }
        return NotFound();
    }
    #endregion
}

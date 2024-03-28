using Infrastructures.Dto;
using Infrastructures.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController(ContactManager contactManager) : ControllerBase
{
    private readonly ContactManager _contactManager = contactManager;

    [HttpPost]
    public async Task<IActionResult> Create(ContactDto dto)
    {
        if (ModelState.IsValid)
        {
            var result = await _contactManager.CreateAsync(dto);
            if (result != null)
            {
                return Created("", null);
            }
            return Problem();
        }
        return BadRequest();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(int id)
    {
        var sender = await _contactManager.GetOneAsync(id);
        if (sender != null)
        {
            return Ok(sender);
        }
        return NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> GetOne(string email)
    {
        var sender = await _contactManager.GetOneAsync(email);
        if (sender.Any())
        {
            return Ok(sender);
        }
        return NotFound();
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var senders = await _contactManager.GetAll();
        if (senders.Any())
        {
            return Ok(senders);
        }

        return NotFound();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var exists = await _contactManager.GetOneAsync(id);
        if (exists != null)
        {
            var result = await _contactManager.DeleteAsync(id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return Problem();
            }
        }
        return NotFound();
    }
}

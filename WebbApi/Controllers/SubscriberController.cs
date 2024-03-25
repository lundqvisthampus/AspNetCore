using Infrastructures.Contexts;
using Infrastructures.Dto;
using Infrastructures.Models;
using Infrastructures.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebbApi.Filters;

namespace WebbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[UseApiKey]
public class SubscriberController(SubscribeManager subscribeManager) : ControllerBase
{
    private readonly SubscribeManager _subscribeManager = subscribeManager;

    #region CREATE
    [HttpPost]
    public async Task<IActionResult> Create(SubscribeDto dto)
    {
        if (ModelState.IsValid)
        {
            var result = await _subscribeManager.GetOneAsync(dto.Email);
            if (result == null)
            {
                try
                {
                    await _subscribeManager.CreateAsync(dto);
                    return Created("", null);
                }
                catch
                {
                    return Problem("Unable to create subscription");
                }
            }
            else
            {
                return Conflict("Email already subscribed.");
            }
        }

        return BadRequest();
    }
    #endregion


    #region READ
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var subscribers = await _subscribeManager.GetAll();
        if (subscribers.Any())
        {
            return Ok(subscribers);
        }

        return NotFound();
    }

    [HttpGet("one")]
    public async Task<IActionResult> GetOne(string email)
    {
        var subscriber = await _subscribeManager.GetOneAsync(email);
        if (subscriber != null)
        {
            return Ok(subscriber);
        }

        return NotFound();
    }
    #endregion


    #region DELETE
    [HttpDelete]
    public async Task<IActionResult> DeleteOne(string email)
    {
        var exists = await _subscribeManager.GetOneAsync(email);
        if (exists != null)
        {
            var result = await _subscribeManager.DeleteAsync(email);
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

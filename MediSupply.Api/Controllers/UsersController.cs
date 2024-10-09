using MediSupply.Api.Core.Abstractions;
using MediSupply.Api.Data;
using MediSupply.Api.Models;
using MediSupply.Api.Models.DTOs;
using MediSupply.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediSupply.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsersController(AppDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var allUsers = _context.Users.ToList();

        return Ok(allUsers);
    }
    
}
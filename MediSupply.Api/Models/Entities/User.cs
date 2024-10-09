using System.ComponentModel.DataAnnotations;

namespace MediSupply.Api.Models;

public enum UserRole
{
    Admin = 0,
    Comprador = 1,
    Cliente = 2
}

public class User
{
    public int Id { get; set; }

    public required string Username { get; set; }

    public required string Password { get; set; }

    public UserRole Role { get; set; }

    public ICollection<UserArea> UserAreas { get; set; }
}
namespace MediSupply.Api.Models.DTOs;

public class SignupDto
{
    public required string Username { get; set; }
    
    public required string Password { get; set; }
    
    public UserRole Role { get; set; }
}
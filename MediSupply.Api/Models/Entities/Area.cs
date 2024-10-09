using System.ComponentModel.DataAnnotations;

namespace MediSupply.Api.Models;

public class Area
{
    public int Id { get; set; }
    
    public required string Name { get; set; }
    
    public required string Description { get; set; }
    
    public ICollection<UserArea> UserAreas { get; set; }
    
}
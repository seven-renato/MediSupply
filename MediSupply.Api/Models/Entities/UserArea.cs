namespace MediSupply.Api.Models;

public class UserArea
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public required User User { get; set; }
        
    public int AreaId { get; set; }
    public required Area Area { get; set; }
}
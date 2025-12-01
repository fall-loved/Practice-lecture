namespace proj.Models;

public class Property
{
    public int Id { get; set; }
    public string Address { get; set; }
    public decimal Price { get; set; }
    public string Type { get; set; } 
    public int OwnerId { get; set; }
    public Owner Owner { get; set; } = null!;
}

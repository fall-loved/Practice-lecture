namespace proj.Models;

public class Owner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Property> Properties { get; set; } = null!;
}
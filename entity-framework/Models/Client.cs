namespace proj.Models;

public class Client
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public ICollection<Viewing> Viewings { get; set; } = new List<Viewing>();
    public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
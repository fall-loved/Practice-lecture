namespace proj.Models;

public class Agent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Viewing> Viewings { get; set; } = new List<Viewing>();
    public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
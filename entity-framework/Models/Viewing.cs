namespace proj.Models;

public class Viewing
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int PropertyId { get; set; }
    public Property Property { get; set; } = null!;
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;
    public int AgentId { get; set; }
    public Agent Agent { get; set; } = null!;
}
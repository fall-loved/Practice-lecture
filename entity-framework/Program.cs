using proj.Data;
using proj.Models;

namespace proj;

public class Program
{
    public static void Main()
    {
        using var db = new EstateContext();
        
        var owner = new Owner { Name = "The head" };
        db.Owners.Add(owner);
        
        var property = new Property { Address = "metanit avenue, 33", Price = 50000, Type = "Property", Owner = owner };
        db.Properties.Add(property);
        
        var client = new Client { FullName = "Client name" };
        db.Clients.Add(client);
        
        var agent = new Agent { Name = "Some agent" };
        db.Agents.Add(agent);
        
        var viewing = new Viewing { Date = DateTime.UtcNow, Property = property, Client = client, Agent = agent };
        db.Viewings.Add(viewing);
        
        var contract = new Contract { Type = "Money making", Date = DateTime.UtcNow, Amount = 50000, Property = property, Client = client, Agent = agent };
        db.Contracts.Add(contract);
        
        db.SaveChanges();
        
        var cheapProperties = db.Properties.Where(p => p.Price < 100000).ToList();
        foreach (var value in cheapProperties)
        {
            Console.WriteLine($"Id: {value.Id} \nAddress: {value.Address} \nPrice: {value.Price} \nType: {value.Type} \nOwnerId: {value.OwnerId} \n");
        }
        
        var clientViewings = db.Viewings.Where(v => v.ClientId == client.Id).ToList();
        foreach (var value in clientViewings)
        {
            Console.WriteLine($"Id: {value.Id}\nDate: {value.Date} \nPropertyId: {value.PropertyId} \nAgentId: {value.AgentId} \nClientId: {value.ClientId} \n");
        }
        
        property.Price = 55000;

        db.Contracts.Remove(contract);
        
        db.SaveChanges();
    }
}
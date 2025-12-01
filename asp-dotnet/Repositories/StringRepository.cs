namespace MyWebApplication.Repositories;

public static class StringRepository
{
    private static readonly List<string> Items = [];

    public static string GetAllItems()
    {
        var items = Items.Count == 0 ? "no strings found" : "strings found:\n";
        
        foreach (var item in Items)
        {
            items += $"{item}\n";
        }
        
        return items;
    }

    public static void AddItem(string item)
    {
        Items.Add(item);
    }
}

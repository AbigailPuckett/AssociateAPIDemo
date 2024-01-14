namespace APIDemo.Data;

public class Fruit(string name, string description, Freshness freshness, double weight, double price)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public Freshness Freshness { get; set; } = freshness;
    public double Weight { get; set; } = weight;
    public double Price { get; set; } = price;
}

public enum Freshness
{
    Fresh = 69, 
    Rotten = 420
}

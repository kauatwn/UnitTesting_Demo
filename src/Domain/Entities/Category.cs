namespace Domain.Entities;

public class Category(int id, string name)
{
    public int Id { get; private set; } = id;
    public string Name { get; private set; } = name;
}
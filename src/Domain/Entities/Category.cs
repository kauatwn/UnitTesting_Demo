namespace Domain.Entities;

public class Category(int id, string name)
{
    public int Id { get; private set; } = id;
    public string Name { get; private set; } = name;

    public void UpdateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty or whitespace.");
        }

        Name = name;
    }
}
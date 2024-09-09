using Domain.Entities;

namespace Domain.UnitTests.Entities;

public class CategoryTest
{
    [Fact]
    public void ShouldCreateCategoryAndSetProperties()
    {
        // Arrange & Act
        var category = new Category(1, "Electronics");

        // Assert
        Assert.NotNull(category);
        Assert.Equal(1, category.Id);
        Assert.Equal("Electronics", category.Name);
    }
}
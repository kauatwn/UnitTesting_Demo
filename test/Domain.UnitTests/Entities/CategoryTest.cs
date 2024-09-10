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

    [Fact]
    public void ShouldUpdateCategoryName()
    {
        // Arrange
        var category = new Category(1, "Electronics");

        // Act
        category.UpdateName("Home Appliances");

        // Assert
        Assert.Equal("Home Appliances", category.Name);
    }

    [Fact]
    public void ShouldThrowExceptionWhenUpdatingNameToEmpty()
    {
        // Arrange
        var category = new Category(1, "Electronics");

        // Act
        var exception = Assert.Throws<ArgumentException>(() => category.UpdateName(string.Empty));

        // Assert
        Assert.Equal("Name cannot be empty or whitespace.", exception.Message);
    }
}
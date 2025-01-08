using Moq;
namespace ShapesRFun.Tests;


//xUnit test for Square GetArea and DoubleArea
public class SquareTestsPartOne
{
    [Fact]
    public void SquareAreaTests1()
    {
        // Arrange
        int dimension = 5;
        int expectedArea = 25;

        var square = new Square { Dimension = dimension };

        // Act
        var actualArea = square.GetArea();

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void SquareDoubleAreaTest1()
    {
        // Arrange
        int dimension = 5;
        int expectedArea = 50;
        var square = new Square { Dimension = dimension };
        // Act
        var actualArea = square.DoubleArea();
        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void SquareHalveAreaTest1()
    {
        int dimension = 4;
        int expectedArea = 8;
        var square = new Square { Dimension = dimension };

        var actualArea = square.HalveArea();

        Assert.Equal(expectedArea, actualArea);
    }
}





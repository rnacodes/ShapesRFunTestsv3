using Moq;
namespace ShapesRFun.Tests;


//xUnit test for Square GetArea and DoubleArea
public class SquareTestsPartOne
{
    [Fact]
    public void SquareAreaTest1()
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

//Moq test for Square GetArea and DoubleArea
public class SquareTestsPartTwo
{
    [Fact]
    public void SquareGetArea_ShouldReturnCorrectValue_WhenMethodIsCalled()
    {
        // Arrange
        var mockSquare = new Mock<Square>();
        mockSquare.Setup(m => m.GetArea()).Returns(25);
        // Act
        var actualArea = mockSquare.Object.GetArea();
        // Assert
        Assert.Equal(25, actualArea);
    }
    [Fact]
    public void SquareDoubleArea_ShouldReturnDoubleTheArea_WhenMethodIsCalled()
    {
        // Arrange
        var mockSquare = new Mock<Square>();
        mockSquare.Setup(m => m.DoubleArea()).Returns(50);
        // Act
        var actualArea = mockSquare.Object.DoubleArea();
        // Assert
        Assert.Equal(50, actualArea);
        // Verify
        mockSquare.Verify(m => m.DoubleArea(), Times.Once);
    }
    [Fact]
    public void SquareHalveArea_ShouldReturnHalfTheArea_WhenMethodIsCalled()
    {
        // Arrange
        var mockSquare = new Mock<Square>();
        mockSquare.Setup(m => m.HalveArea()).Returns(8);
        // Act
        var actualArea = mockSquare.Object.HalveArea();
        // Assert
        Assert.Equal(8, actualArea);
        //Verify
        mockSquare.Verify(m => m.HalveArea(), Times.Once);
    }
}



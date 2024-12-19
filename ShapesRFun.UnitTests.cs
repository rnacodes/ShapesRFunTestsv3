using ShapesRFun;

namespace ShapesRFun.Tests;
public class SquareTest
{
    
    [Fact]
    public void SquareAreaTest()
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
    public void SquareDoubleAreaTest()
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

}

    public class AddShapesTest
{
    [Fact]
    public void AddShapesHereTest()
    {
        // Arrange
        int shape1Area = 25;
        int shape2Area = 25;
        int expectedArea = 50;
        var addShapes = new AddShapes();
        // Act
        var actualArea = addShapes.AddShapesHere(shape1Area, shape2Area);
        // Assert
        Assert.Equal(expectedArea, actualArea);
    }


    [Fact]
    public void Test2()
    {

    }
}

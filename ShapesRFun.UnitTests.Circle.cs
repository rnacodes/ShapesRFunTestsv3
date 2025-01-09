using Moq;
namespace ShapesRFun.Tests;


//xUnit test for Circle GetArea and GetPerimeter
public class CircleTestsPartOne
{
    [Fact]
    public void CircleAreaTest1()
    {
        //Arrange
        int dimension = 10;
        int expectedCircleArea = 314;
        var testCircle = new Circle { Dimension = dimension };

        //Act
        int actualCircleArea = testCircle.GetArea();

        //Assert
        Assert.Equal(expectedCircleArea, actualCircleArea);
    }

    [Fact]
    public void CirclePerimeterTest1()
    {

        //Arrange
        int dimension = 10;
        int expectedCirclePerimeter = 62;
        var testCircle2 = new Circle { Dimension = dimension };

        //Act
        int actualCirclePerimeter = testCircle2.GetPerimeter();

        //Assert
        Assert.Equal(expectedCirclePerimeter, actualCirclePerimeter);
    }
}

//Moq tests for Circle GetArea and GetPerimeter
public class CircleTests2()
{
    [Fact]
    public void CircleGetArea_ShouldReturnProperValue_WhenMethodIsCalled()
    {
        //Arrange
        var mockCircle = new Mock<Circle>();
        mockCircle.Setup(m => m.GetArea()).Returns(500);
        //Act
        var actualArea = mockCircle.Object.GetArea();
        //Assert
        Assert.Equal(500, actualArea);
        //Verify
        mockCircle.Verify(m => m.GetArea(), Times.Once);
    }
}








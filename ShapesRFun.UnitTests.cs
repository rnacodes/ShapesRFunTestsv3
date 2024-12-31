using Moq;
using ShapesRFun.Bases;



namespace ShapesRFun.Tests;
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

}

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


    public class AddShapesTest1
    {

        //XUnit test for AddShapesHere
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


        // More complicated tests coming soon!

        //Moq test for AddShapesHere
        //[Fact]
    }

    public class AddShapesTest2 { 
        [Fact]
        public void AddShapesHere_AddTwoSimpleShapes()
        {
            //Arrange - setting up the mock shapes and class to add their areas
            var mockSimpleShape1 = new Mock<Circle>(); //Indicate what is going to be mocked.
            var mockSimpleShape2 = new Mock<Square>();

            mockSimpleShape1.Setup(m => m.GetArea()).Returns(10); //Is this creating a shape such that when you use GetArea, it returns 10?
            mockSimpleShape2.Setup(m => m.GetArea()).Returns(5);

            int mockArea1 = mockSimpleShape1.Object.GetArea();
            int mockArea2 = mockSimpleShape2.Object.GetArea();

            //Instantiation of AddShapes class
            var addShapesMock = new AddShapes();

            var addShapesAreaMock = addShapesMock.AddShapesHere(mockArea1, mockArea2);

        }
    }

    //Tests for shape specific methods

    /*
    void ICalculateAreaClassTest1()
    {

        //Create mock instantiantion of GetAreaClass with specific answer?
        var letsTestGetAreaClass = new Mock<ICalculateArea>();
        letsTestGetAreaClass.Setup(m => m.GetArea()).Returns(26);

        //Testing GetArea
        var testArea = letsTestGetAreaClass.Object.GetArea();

        Assert.Equal(26, testArea);
        letsTestGetAreaClass.Verify(m => m.GetArea(), Times.Once);

    }
    */

}


    





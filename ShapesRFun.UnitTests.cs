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
        //xUnit test for AddShapesHere
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
    }

    //Moq test for AddShapesHere
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

    //Moq tests are not needed for static methods

    public class ShapesFunTricksTest {
    
        [Fact]
        public void RectangleMagicNumberTest()
        {
            //Arrange
            string expectedRectangleMagicNumber = "The answer to all questions is 42.";
            //Act
            string actualRectangleMagicNumber = Rectangle.RectangleMagicNumber();
            //Assert
            Assert.Equal(expectedRectangleMagicNumber, actualRectangleMagicNumber);
        }
    }

    /* Triangle Special Joke test will go here
        [Fact]

        public void TriangleSpecialJokeTest
*/


    //Tests for Shape Special methods



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


    





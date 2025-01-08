using Moq;
namespace ShapesRFun.Tests;


//xUnit test for AddShapesHere
    public class AddShapesTest1 {       
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
        public void AddShapesHere_AddTwoSimpleShapes_ShouldReturnCombinedValue()
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
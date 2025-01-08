using Moq;
using ShapesRFun;
using Xunit;

namespace ShapesRFun.Tests;
//Tests for Shape Special methods - all are created using xUnit as they are static methods
public class ShapesFunTricksTest
{

    [Fact]
    public void RectangleMagicNumber_ShouldReturnProperMessage_WhenMethodIsCalled()
    {
        //Arrange
        string expectedRectangleMagicNumber = "The answer to all questions is 42.";
        //Act
        string actualRectangleMagicNumber = Rectangle.RectangleMagicNumber();
        //Assert
        Assert.Equal(expectedRectangleMagicNumber, actualRectangleMagicNumber);
    }

    //QUESTION: I can't figure out why I can't do the square test like the rectangle's?

    /*
    [Fact]
    public void SquareSpecial_ShouldReturnProperMessage_WhenMethodIsCalled()
    {
        //Arrange
        string expectedSquareSpecialMessage = "What is a square's favorite song? Hip to be Square!";
        var square = new Square();
        //Act
        square.SquareSpecial();
        string actualSquareSpecialMessage = "What is a square's favorite song? Hip to be Square!";

        //Assert
        Assert.Equal(expectedSquareSpecialMessage, actualSquareSpecialMessage);
    }
    */
}

    



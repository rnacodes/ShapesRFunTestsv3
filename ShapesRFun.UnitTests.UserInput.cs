using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
namespace ShapesRFun.Tests;

public class UserInputForShape1
{
    //Moq test for user input
    [Fact]
    public void Main_InvalidInput_ThrowsInvalidInputException()
    {
        // Arrange
        var input = "invalidShape\n";
        var inputReader = new StringReader(input);
        Console.SetIn(inputReader);

        // Act & Assert
        var exception = Assert.Throws<InvalidInputException>(() => Program.Main(null));
        Assert.Equal("Please enter a valid shape (square, circle, rectangle, triangle).", exception.Message);
    }
}






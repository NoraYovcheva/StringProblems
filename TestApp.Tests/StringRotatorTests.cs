using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        int rotation = 2;
        string expected = string.Empty;

        //Act
        string result = StringRotator.RotateRight(input, rotation);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //Arrange
        string input = "hello";
        int rotation = 0;
        string expected = "hello";

        //Act
        string result = StringRotator.RotateRight(input, rotation);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdef";
        int rotation = 2;
        string expected = "efabcd";

        //Act
        string result = StringRotator.RotateRight(input, rotation);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "12345";
        int rotation = -2;
        string expected = "45123";

        //Act
        string result = StringRotator.RotateRight(input, rotation);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //Arrange
        string input = "xyz";
        int rotation = 5;
        string expected = "yzx";

        //Act
        string result = StringRotator.RotateRight(input, rotation);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }
}

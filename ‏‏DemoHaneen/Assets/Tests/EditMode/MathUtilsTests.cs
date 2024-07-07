using NUnit.Framework;

[TestFixture]
public class MathUtilsTests
{
    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = MathUtils.Add(a, b);

        // Assert
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = MathUtils.Multiply(a, b);

        // Assert
        Assert.AreEqual(15, result);
    }
    [Test]
    public void DevideByZero_ShouldReturnException() {
        int a = 5;
        int b = 0;

        Assert.Catch(typeof(System.Exception),()=> MathUtils.Div(a, b));


    }
}

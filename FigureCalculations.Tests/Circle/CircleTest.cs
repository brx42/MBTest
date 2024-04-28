namespace FigureCalculations.Tests.Circle;

public class CircleTest
{
    [Fact]
    public void MustCalculateTheAreaCorrectly()
    {
        Implementations.Circle circle = new(15);
        const double valid = 706.85834705770344;

        double result = circle.GetArea();

        Assert.Equal(valid, result);
    }
}
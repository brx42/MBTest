namespace FigureCalculations.Tests.Triangle;

public class TriangleTest
{
    [Fact]
    public void MustCorrectlyCalculateTheArea()
    {
        Implementations.Triangle triangle = new(4, 6, 8);
        const double valid = 11.6;
        
        double result = triangle.GetArea();
        
        Assert.Equal(valid, result);
    }
    
    [Fact]
    public void CheckingForARightTriangle()
    {
        Implementations.Triangle triangle = new(6, 6, 4);
        
        bool result = triangle.IsRightTriangle;
        
        Assert.False(result);
    }
}
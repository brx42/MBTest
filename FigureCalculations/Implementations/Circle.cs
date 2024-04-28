using FigureCalculations.Interfaces;

namespace FigureCalculations.Implementations;

/// <summary>
/// Объект круга
/// </summary>
public class Circle : ICircle
{
    /// <summary>
    /// Радиус окружности.
    /// </summary>
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), $"The {nameof(radius)} field value must be greater than 0");
        }
        
        Radius = radius;
    }

    /// <inheritdoc />
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    /// <inheritdoc />
    public async Task<double> GetAreaAsync()
    {
        return await Task.FromResult(GetArea());
    }
}
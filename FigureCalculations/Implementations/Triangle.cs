using FigureCalculations.Interfaces;

namespace FigureCalculations.Implementations;

/// <summary>
/// Объект треугольника
/// </summary>
public class Triangle : ITriangle
{
    /// <inheritdoc />
    public double SideA { get; }

    /// <inheritdoc />
    public double SideB { get; }

    /// <inheritdoc />
    public double SideC { get; }

    /// <inheritdoc />
    public bool IsRightTriangle { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentOutOfRangeException(string.Join('|', sideA, sideB, sideC), "One or more sides must be greater than 0");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        IsRightTriangle = GetInfoAboutIsRightTriangle();
    }

    public double GetArea()
    {
        double perimeter = (SideA + SideB + SideC) / 2;

        double square = Math.Round(Math.Sqrt(
            perimeter *
            (perimeter - SideA) *
            (perimeter - SideB) *
            (perimeter - SideC)), 1);

        return square;
    }

    public async Task<double> GetAreaAsync()
    {
        return await Task.FromResult(GetArea());
    }

    private bool GetInfoAboutIsRightTriangle()
    {
        return SideA * SideA + SideB * SideB == SideC * SideC ||
               SideC * SideC + SideB * SideB == SideA * SideA ||
               SideA * SideA + SideC * SideC == SideB * SideB;
    }
}
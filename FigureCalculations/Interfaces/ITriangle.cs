namespace FigureCalculations.Interfaces;

/// <summary>
/// Интерфейс треугольника
/// </summary>
public interface ITriangle : IFigure
{
    /// <summary>
    /// Сторона A
    /// </summary>
    double SideA { get; }
    
    /// <summary>
    /// Сторона B
    /// </summary>
    double SideB { get; }
    
    /// <summary>
    /// Сторона C
    /// </summary>
    double SideC { get; }
    
    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    bool IsRightTriangle { get; }
}
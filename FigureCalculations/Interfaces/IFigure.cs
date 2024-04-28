namespace FigureCalculations.Interfaces;

/// <summary>
/// Интерфейс фигуры.
/// </summary>
public interface IFigure
{
    /// <summary>
    /// Получение площади фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    double GetArea();

    /// <summary>
    /// Получение площади фигуры асинхронно.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    Task<double> GetAreaAsync();
}
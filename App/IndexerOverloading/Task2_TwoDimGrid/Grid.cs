// Задача: Перегрузка индексаторов — Grid<T>
// Реализуйте индексаторы: [row, col], по структуре Cell и по одномерному индексу [index] (row-major).

using System.Runtime.CompilerServices;

namespace App.IndexerOverloading.Task2_TwoDimGrid;

public readonly struct Cell
{
    public int Row { get; }
    public int Col { get; }
    public Cell(int row, int col)
    {
        this.Row = row;
        this.Col = col;
    }
}

public class Grid<T>
{
    public int Rows { get; }
    public int Cols { get; }

    public Grid(int rows, int cols)
    {
        this.Rows = rows;
        this.Cols = Cols;
    }

    public T this[int row, int col]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public T this[Cell cell]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public T this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}
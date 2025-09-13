// Задача: Перегрузка конструкторов — IntMatrix
// Реализуйте класс IntMatrix с перегруженными конструкторами согласно README.
// Рекомендуется использовать цепочки конструкторов для устранения дублирования кода.

namespace App.ConstructorOverloading.Task2_Matrix;

public class IntMatrix
{
    // Размеры матрицы
    private int[,] _array;
    public int RowCount { get { return this._array.GetUpperBound(0) + 1; } }
    public int ColCount { get { return this._array.GetUpperBound(1) + 1; } }

    // Индексатор для проверки значений в тестах
    public int this[int row, int col]
    {
        get => _array[row, col];
    }

    // Конструктор (rows, cols) — заполняет нулями
    public IntMatrix(int rows, int cols)
    {
        if (rows < 1 || cols < 1) throw new ArgumentException();
        this._array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                this._array[i, j] = 0;
            }
        }
    }

    // Конструктор из прямоугольного массива
    public IntMatrix(int[,] data)
    {
        this._array = data;
    }

    // Конструктор из ступенчатого массива (все строки должны быть одинаковой длины)
    public IntMatrix(int[][] data)
    {
        if (data[0].Length != data[1].Length) throw new ArgumentException();
        this._array = new int[data.Length, data[0].Length];
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data[0].Length; j++)
            {
                this._array[i, j] = data[i][j];
            }
        }
    }
}
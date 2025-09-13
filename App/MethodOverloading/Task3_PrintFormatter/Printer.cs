// Задача: Перегрузка методов — Print
// Реализуйте перегруженные методы Print согласно README. Методы должны возвращать строку.
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace App.MethodOverloading.Task3_PrintFormatter;

public static class Printer
{
    public static string Print(int value)
    {
        return Convert.ToString(value, CultureInfo.InvariantCulture);
    }

    public static string Print(double value, int decimals)
    {
        return Convert.ToString(Math.Round(value, decimals), CultureInfo.InvariantCulture); 
    }

    public static string Print(params int[] values)
    {
        return string.Join(",", values, CultureInfo.InvariantCulture);
    }

    public static string Print<T>(IEnumerable<T> values)
    {
        throw new NotImplementedException();
    }
}
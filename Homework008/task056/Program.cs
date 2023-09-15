// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] ints, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.GetLength(0); i++)
        for (int j = 0; j < ints.GetLength(1); j++)
            ints[i, j] = rnd.Next(minValue, maxValue + 1);  // Next(2, 5) -> [2, 5)
}

void Print2DArray(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
            Console.Write($"{ints[i, j]}\t");
        Console.WriteLine();
    }
}
int[] SumColsArray(int[,] ints)
{
    int[] sum = new int[ints.GetLength(0)];
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            sum[i] += ints[i, j];
        }
    }
    return sum;
}
void ConsoleLowestSumInCols(int[] array)
{
    int min = array[0];
    int rows = 1;
    // string indexTxt = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            rows = i + 1;
            // indexTxt += rows;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в массиве равна: {min}. Она находится в {rows} строке.");
}
int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите минимальное значение диапазона: ");
int max = InputNum("Введите максимальное значение диапазона: ");
int[,] originalArray = Create2DArray(rows, cols);
Fill2DArray(originalArray, min, max);
Print2DArray(originalArray);
Console.WriteLine(string.Join(" ", SumColsArray(originalArray)));
ConsoleLowestSumInCols(SumColsArray(originalArray));
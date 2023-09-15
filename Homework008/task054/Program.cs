// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void SortArray(int[,] ints)
{
    int max = ints[0, 0];
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            for (int e = 0; e < ints.GetLength(1) - 1; e++)
            {
                if (ints[i, e] < ints[i, e + 1])
                {
                    max = ints[i, e + 1];
                    ints[i, e + 1] = ints[i, e];
                    ints[i, e] = max;
                }
            }
        }
    }
}
Console.WriteLine("Продолжить с массивом из задачи? Ответьте Да или  Нет ");
string answer = Console.ReadLine();
if (answer == "Да")
{
    int[,] originalArray = new int[,]
    {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
    };
    Print2DArray(originalArray);
    Console.WriteLine();
    SortArray(originalArray);
    Print2DArray(originalArray);
}
else
{
    int rows = InputNum("Введите количество строк: ");
    int cols = InputNum("Введите количество столбцов: ");
    int min = InputNum("Введите минимальное значение диапазона: ");
    int max = InputNum("Введите максимальное значение диапазона: ");
    int[,] originalArray = Create2DArray(rows, cols);
    Fill2DArray(originalArray, min, max);
    Print2DArray(originalArray);
    Console.WriteLine();
    SortArray(originalArray);
    Print2DArray(originalArray);
}


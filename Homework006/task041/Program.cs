// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FillArray(int[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
}
int ArrayNumberAboveZero (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
int min = InputNum("Введите минимальное число для массива: ");
int max = InputNum("Введите максимальное число для массива: ");
int arraySize = InputNum("Введите длинну массива: ");
int[] myArray = new int[arraySize];
FillArray(myArray, min, max);
PrintArray(myArray);
int m = ArrayNumberAboveZero(myArray);
Console.WriteLine(m);
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
void FillArray(double[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = new Random().NextDouble() * (0 + 20);
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    }
}

void FindMaxAndMinArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"min value: {min}, max value: {max}.");
}

double[] array = new double[10];
FillArray(array, -100, 100);
PrintArray(array);
FindMaxAndMinArray(array);
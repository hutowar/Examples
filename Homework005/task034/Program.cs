// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
}
int EvenNumberedCounter(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

int[] array = new int[20];
FillArray(array, 100, 999);
PrintArray(array);
int even = EvenNumberedCounter(array);
Console.WriteLine(even);

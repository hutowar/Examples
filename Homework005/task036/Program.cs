// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int SumNotEvenPosArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}
int[] array = new int[20];
FillArray(array, -100, 100);
PrintArray(array);
int notEvenSum = SumNotEvenPosArray(array);
for (int i = 1; i < array.Length; i+=2)
    {
        Console.Write($"|{i}: {array[i]}| + ");
    }
Console.Write($"0 = {notEvenSum}");

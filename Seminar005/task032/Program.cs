// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
void FillArray (int[] ints)
{ Random rnd = new Random();
for (int i = 0; i < ints.Length; i++)
ints[i] = rnd.Next(-9, 10);
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
Console.Write($"{arr[i]} ");
Console.WriteLine();
}

void ChangeSign (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    Console.WriteLine();
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
ChangeSign(array);
PrintArray(array);

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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


void SumPosNegNums(int[] arr)
{
int posSum = 0;
int negSum = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] > 0)
posSum += arr[i]; // posSum = posSum + arr[i];
else
negSum += arr[i];
}
Console.WriteLine($"Сумма положительных чисел равна {posSum}");
Console.WriteLine($"Сумма отрицательных чисел равна {negSum}");
}

int[] newArray = new int[12];
FillArray(newArray);
PrintArray(newArray);
SumPosNegNums(newArray);

// int[] SumPosNegNums(int[] arr) // через возврат
// {
// int[] sums = new int[2];
// for (int i = 0; i < arr.Length; i++)
// {
// if (arr[i] > 0)
// sums[0] += arr[i]; // posSum = posSum + arr[i];
// else
// sums[1] += arr[i];
// }
// return sums;
// }
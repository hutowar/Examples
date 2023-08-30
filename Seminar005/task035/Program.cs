/*Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2]-> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5
*/
void FillArray(int[] ints)
{
Random rnd = new Random();
for (int i = 0; i < ints.Length; i++)
ints[i] = rnd.Next(0, 201);
}

int AmountNumsInDiap(int[] array, int start, int end)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] >= start && array[i] <= end)
{
count++;
}
}
return count;
}

int[] arrayForNumbers = new int[123];

FillArray(arrayForNumbers);
int result = AmountNumsInDiap(arrayForNumbers, 10, 99);
Console.WriteLine(result);
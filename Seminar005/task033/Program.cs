// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
void FillArray(int[] ints)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
        ints[i] = rnd.Next(-9, 10);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

bool FindNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == num)
            return true;
    return false;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine(FindNum(array, 8));

// void FindNum(int[] fNum, int num) 
// {
//     int count = 0;
//     for (int i = 0; i < fNum.Length; i++)
//     {
//         if (fNum[i] == num)
//         {
//             count++;
//         }
//     }
//     if (count == 0)
//     {
//         Console.WriteLine("нет");
//     }
//     else
//     {
//         Console.WriteLine("да");
//     }
// }
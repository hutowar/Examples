// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void Fill3DArray(int[,,] array)
{
    bool[] used = new bool[100]; // Массив для отслеживания использованных чисел

    Random random = new Random();

    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                int num;
                do
                {
                    num = random.Next(10, 100); // Генерация случайного двузначного числа
                } while (used[num]); // Проверка, чтобы число не повторялось

                used[num] = true; // Отмечаем число как использованное
                array[x, y, z] = num;
            }
        }
    }
}
void Print3DArray(int[,,] array)
{
    int depth = array.GetLength(0);
    int rows = array.GetLength(1);
    int columns = array.GetLength(2);

    for (int d = 0; d < depth; d++)
    {
        Console.WriteLine($"Layer {d + 1}:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[d, i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int depth = InputNum("Input depth: ");
int rows = InputNum("Input rows: ");
int columns = InputNum("Input columns: "); 

int[,,] array = new int[depth, rows, columns];

Fill3DArray(array);
Print3DArray(array);
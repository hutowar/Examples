void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int pos = 0;
    Console.Write("*/");
    while (pos < col.Length)
    {
        Console.Write(col[pos] + " ");
        pos++;
    }
    Console.WriteLine("/*");
}

int IndexOf(int[] collection, int find)
{
    int index = 0;
    int position = -1;
    while (index < collection.Length)
    {
        if (find == collection[index])
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int ind = 7;
int pos = IndexOf(array, ind);
if(pos == -1)
{
    Console.WriteLine("Позия элеманта: " + ind + " не найдена.");
}
else    Console.WriteLine("Позия элеманта: " + ind + " равна: " + pos);

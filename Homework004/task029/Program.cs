// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int CreateArraySize()
{
    return InputNum("size array: ");
}
void CreateArrayInput(int[] arrayName)
{
    for (int i = 0; i < arrayName.Length; i++)
    {
        arrayName[i] = InputNum($"Array index: {i} will contain: ");
    }
}
void PrintArray (int[] array)
{
for (int j = 0; j < array.Length; j++)
{
    
    Console.Write(" "+ array[j]);
    if (j+1 < array.Length) 
    {
        Console.Write(",");
    }
    else Console.Write(".");
}
}
int[] a = new int [CreateArraySize()];
CreateArrayInput(a);

PrintArray(a);
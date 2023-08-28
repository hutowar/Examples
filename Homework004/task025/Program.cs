// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int DegreeOfNumber(int a, int b)
{
    int theA = a;
    for (int i = 1; i < b; i++)
    {
        a *= theA;
    }
    return a;
}
int digitA = InputNum("Введите число A: ");
int digitB = InputNum("Введите число B: ");
int degreeof = DegreeOfNumber(digitA, digitB);
Console.WriteLine(degreeof);
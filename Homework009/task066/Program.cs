/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int SumNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + SumNaturalNumbers(m + 1, n);
    }
}
int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");
int sum = SumNaturalNumbers(m, n);
Console.WriteLine(sum);
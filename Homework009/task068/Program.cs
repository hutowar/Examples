/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
long InputNum(string message)
{
    Console.Write(message);
    return long.Parse(Console.ReadLine()!);
}
static long Ackermann(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return 0; // Для случаев, когда входные значения m и n не соответствуют условиям
}

long m = InputNum("Введите число m: "), n = InputNum("Введите число n: ");
long result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
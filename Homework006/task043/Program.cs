// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double InputNum (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}
void PointIntersection (double b1, double k1, double b2, double k2)
{
    double x = (b1-b2)/(k2-k1);
    double y = (k2 * x + b2);
    Console.WriteLine($"({x}; {y})");
}
double b1 = InputNum("Введите переменную b1: ");
double k1 = InputNum("Введите переменную k1: ");
double b2 = InputNum("Введите переменную b2: ");
double k2 = InputNum("Введите переменную k2: ");
PointIntersection(b1, k1, b2, k2);
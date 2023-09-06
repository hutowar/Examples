// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
bool TriangleInequality(int ab, int bc, int ca)
{
    return (ab + bc > ca && bc + ca > ab && ca + ab > bc);
}
int abEdge = InputNum("Введите длинну стортоны точек a-b: ");
int bcEdge = InputNum("Введите длинну стортоны точек b-c: ");
int caEdge = InputNum("Введите длинну стортоны точек c-a: ");
Console.WriteLine(TriangleInequality(abEdge, bcEdge, caEdge));
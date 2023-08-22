/*  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21  */
int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double PointDistance(int AX, int AY, int BX, int BY)
{
    double dist = 0;
    dist = Math.Sqrt(Math.Pow(AX - BX,2) + Math.Pow(AY - BY,2));
    return dist;
}

int AX = InputNum("Введите значение оси координат x для точки A: ");
int AY = InputNum("Введите значение оси координат y для точки A: ");
int BX = InputNum("Введите значение оси координат x для точки B: ");
int BY = InputNum("Введите значение оси координат y для точки B: ");
Console.WriteLine(PointDistance(AX, AY, BX, BY));
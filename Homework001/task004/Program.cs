// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Enter first number: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int n2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter third number: ");
int n3 = int.Parse(Console.ReadLine()!);
int max = n1;
if (n2>max) max = n2;
if (n3>max) max = n3;
Console.WriteLine("Max number is: " + max);
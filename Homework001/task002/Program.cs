// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Enter number1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter number2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 < number2)  Console.WriteLine("Lesser number is - " + number1);
else  Console.WriteLine("Lesser number is - "+ number2);
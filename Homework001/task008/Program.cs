// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
int count = 0;
while (count < number)
{
    count += 2;
    if (count > number) break;
    Console.Write(count+" ");
}
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
int GetThirdNumber(int value)
{
    while (value > 999)
    {
        value /= 10;
    }
    return value % 10;
}
int number = int.Parse(Console.ReadLine()!);
if (number<100)
{
    Console.WriteLine(number+" < 100, нужно трёхзначное число");
}
else Console.WriteLine(GetThirdNumber(number));
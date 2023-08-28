// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int TotalNumberOfNumbers(int number)
{
    int divisionForNumber = 1;
    int result = 0;
    int copyOfNumberForDivision = number;
    for (int i = 0; copyOfNumberForDivision != 0; i++)
    {
        result = result + number / divisionForNumber % 10;
        divisionForNumber *= 10;
        copyOfNumberForDivision /= 10;
    }
    return result;
}
int totalNumber = TotalNumberOfNumbers(InputNum("Введиет число: "));
Console.Write(totalNumber);
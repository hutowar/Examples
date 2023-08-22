/*  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4  */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string SquaresFrom1ToNum(int num)
{
    int count = 1;
    string res = "";
    while (count <= num)
    {
        res += $"{Math.Pow(count, 2)}";
        if (count < num) res += ", ";
        else res += ".";
        count++;
    }
    return res;
}

int number = InputNum("Введите число: ");
Console.WriteLine(SquaresFrom1ToNum(number));
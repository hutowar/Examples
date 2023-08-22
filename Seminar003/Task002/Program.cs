//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void QuarterAvaliable(int quarter)
{
    if (quarter == 1){
        Console.WriteLine("x > 0, y > 0");
    }
    else if (quarter == 2) {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (quarter == 3) {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (quarter == 4) {
        Console.WriteLine("x > 0, y < 0");
    }
    else {
        Console.WriteLine("Четверть не существует.");
    }
}

int quarter = InputNum("Введите четверть: ");
QuarterAvaliable(quarter);
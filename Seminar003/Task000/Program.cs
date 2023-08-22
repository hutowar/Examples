int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Quarter(int axisX, int axisY)
{
    int num = 0;
    // if (axisX > 0 && axisY > 0)
    //     num = 1;
    // else if (axisX < 0 && axisY > 0)
    //     num = 2;
    // else if (axisX < 0 && axisY < 0)
    //     num = 3;
    // else if (axisX > 0 && axisY < 0)
    //     num = 4;
    if (axisX > 0)
    {
        if(axisY > 0) num = 1;
        else num = 4;
    }
    else if(axisX < 0)
    {
        if(axisY > 0) num = 2;
        else num = 3;
    }
    return num;
}

int x = InputNum("Введите координату Х: ");
int y = InputNum("Введите координату Y: ");

int res = Quarter(x, y);
if (res == 0) System.Console.WriteLine("Точка лежит на границе четвертей");
else System.Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в четверти {res}");
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
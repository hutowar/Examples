int a1 = 5, b1 = 2, c1 = 2,
    a2 = 11, b2 = 3, c2 = 12,
    a3 = 8, b3 = 4, c3 = 9;
int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}
Console.Write(Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3)));
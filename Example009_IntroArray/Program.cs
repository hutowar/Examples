int[] array = { 2, 7, 4, 4, 6, 2, 8, 4, 6 };
int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}
Console.Write(Max(Max(array[0], array[1], array[2]),
                  Max(array[3], array[4], array[5]),
                  Max(array[6], array[7], array[8])));
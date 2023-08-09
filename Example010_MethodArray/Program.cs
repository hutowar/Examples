//              0  1  2  3  4  5  6  7  8
int[] array = { 2, 7, 4, 4, 6, 2, 8, 4, 6 };
int count = 0;
int number = int.Parse(Console.ReadLine());
while (number < array.Length)
{
    if (number == array[count])
    {
        Console.WriteLine(count);
        break;
    }
    count++;
}
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// bool IsFiveDigits(int num)
// {
//     return num > 9999 && num < 100000;
// }

// bool IsPalindrome(int num)
// {
//     // int firstDigit = num / 10000;
//     // int secondDigit = num / 1000 % 10;
//     // int forthDigit = num / 10 % 10;
//     // int fifthDigit = num % 10;
//     // if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
//     //     return true;
//     // else
//     //     return false;
//     return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;
// }

// int number = InputNum("Введите пятизначное число: ");
// bool res = IsFiveDigits(number);
// if (res)
// {
//     res  = IsPalindrome(number);
//     System.Console.WriteLine(res);
// }
// else
// {
//     System.Console.WriteLine(res);
//     System.Console.WriteLine("Это не пятизначное число");  
// }

int ReverseNum(int num) 
// 12345 % 10 = 5 
// 12345 /10 = 1234   
//1234 % 10 = 4
// 5 * 10 + 4 = 54
// 1234 /10 = 123
// 123 % 10 = 3
// 54 * 10 + 3 = 543
{
    int res = 0;
    while (num != 0)
    {
        res = res * 10 + num % 10;
        num /= 10;
    }
    return res;
}

bool IsPalindrome(int num, int revNum)
{
    return num == revNum;
}

int num = InputNum("Введите число: ");
int reverseNum = ReverseNum(num);
System.Console.WriteLine(IsPalindrome(num, reverseNum));
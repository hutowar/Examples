using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      bool result = false;
      if (number < 10000 || number > 99999)
      {
        result = false;
      }           //53035
      if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10) //firsthDigit = number / 10000;secondDigit = number / 1000 % 10;forthDigit = number / 10 % 10;fiveDigit = number % 10;
      {
        result = true;
      }
      return result;
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
      for (int i = 1; i < N+1; i++)
      {
        double result = Math.Pow(i, 3);
        Console.WriteLine($"{result}");
      }        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}
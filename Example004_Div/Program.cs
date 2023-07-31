double NumberA = new Random().Next(1, 10); // 1 2 3 4 ... 10
Console.WriteLine(NumberA);
double NumberB = new Random().Next(1, 10);
Console.WriteLine(NumberB);
double result = NumberA / NumberB;
Console.WriteLine(NumberA + " / " + NumberB +" = "+ result);
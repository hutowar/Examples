// void FillDoubleArr(double[] arr, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     // int deviation = 10;
//     for (int i = 0; i < arr.Length; i++)
//         // arr[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation)
//         // arr[i] = Math.Round(rnd.NextDouble()+ rnd.Next(minValue, maxValue), 2);
//         arr[i] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 2); 
//         // [0, 1]   [0, 5]   [2, 7]           // 2-7
// }
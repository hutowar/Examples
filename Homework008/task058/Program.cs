// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}
bool BoolMultiplyingMatrices(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}
void Print2DArray(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
            Console.Write($"{ints[i, j]}\t");
        Console.WriteLine();
    }
}
int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int firstMatrixRows = firstMatrix.GetLength(0);
    int firstMatrixColumns = firstMatrix.GetLength(1);

    int secondMatrixRows = secondMatrix.GetLength(0);
    int secondMatrixColumns = secondMatrix.GetLength(1);

    int[,] resultMatrix = new int[firstMatrixRows, secondMatrixColumns];

// Третий цикл (k) используется для перемножения элементов из первой и второй матриц  и суммирования их значений для заполнения элемента в результирующей матрице.
// Умножение элементов: Внутри третьего цикла, для каждого элемента в результирующей матрице (определяемого i и j), мы вычисляем его значение путем умножения и 
// суммирования элементов из соответствующих строк и столбцов входных матриц. Это происходит следующим образом:
// resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j]
// firstMatrix[i, k] берет элемент из первой матрицы в текущей строке i и текущем столбце k.
// secondMatrix[k, j] берет элемент из второй матрицы в текущей строке k и текущем столбце j.
// Оба элемента перемножаются, и результат прибавляется к значению элемента в результирующей матрице resultMatrix[i, j].
    for (int i = 0; i < firstMatrixRows; i++)
    {
        for (int j = 0; j < secondMatrixColumns; j++)
        {
            for (int k = 0; k < firstMatrixColumns; k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }

        }
    }
    
    return resultMatrix;
}
static void FillArray(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.Write($"Введите значение для элемента [{i}, {j}]: ");
            array[i, j] = int.Parse(Console.ReadLine()!);
        }
    }
}

int rows1 = InputNum("Введите количество строк первой матрицы: ");
int cols1 = InputNum("Введите количество столбцов первой матрицы: ");
int[,] firstMatrix = Create2DArray(rows1, cols1);
FillArray(firstMatrix);
Print2DArray(firstMatrix);

int rows2 = InputNum("Введите количество строк второй матрицы: ");
int cols2 = InputNum("Введите количество столбцов второй матрицы: ");
int[,] secondMatrix = Create2DArray(rows2, cols2);
FillArray(secondMatrix);
Print2DArray(secondMatrix);
if (BoolMultiplyingMatrices(firstMatrix, secondMatrix))
{
    int[,] resultMatrix = MultiplyMatrices(firstMatrix, secondMatrix);
    Console.WriteLine("Результирующая матрциа: ");
    Print2DArray(resultMatrix);
}
else
{
    Console.WriteLine("Матрицы умножить невозможно. Количество столбцов первой матрицы и количество строк второй матрицы не совпадают.");
}
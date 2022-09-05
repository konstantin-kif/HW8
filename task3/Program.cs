// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int numRows, int numColumns, int maxRand = 10, int minRand = 0)             // Функция создания и заполнения двухмерного массива
{
    int[,] matrix = new int[numRows, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)                                  // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)                              // столбец
        {
            matrix[i, j] = new Random().Next(minRand, maxRand);                    //  числа от 0 до 10
        }

    }
    return matrix;
}

void PrintArray(int[,] matrix)                                                    // Функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)                                       // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)                                   // столбец
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationsMatrix(int[,] matrix1, int[,] matrix2)                           // Функция умножения матриц
{
    int[,] sum = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            sum[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum[i, j] += matrix1[i, k] * matrix2[j, k];
            }
        }
    }
    return sum;
}

void Main()
{
    int a = Prompt("Enter the number of rows of the matrix A: ");
    int b = Prompt("Enter the number of columns of the matrix A: ");
    int c = Prompt("Enter the number of rows of the matrix B: ");
    int d = Prompt("Enter the number of columns of the matrix B: ");
    if (!(a > 0 && b > 0 && c > 0 && d > 0))
    {
        Console.WriteLine("It is impossible to solve the problem with such parameters");
        return;
    }
    int[,] array1 = FillArray(a, b);
    int[,] array2 = FillArray(d, c);
    PrintArray(array1);
    Console.WriteLine();
    PrintArray(array2);
    Console.WriteLine();
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Matrices are incompatible");
        return;
    }
    int[,] result = MultiplicationsMatrix(array1, array2);
    PrintArray(result);
}
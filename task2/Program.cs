// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray(int Rows, int Columns, int maxRand = 10, int minRand = 0)             // Функция создания и заполнения двухмерного массива
{
    int[,] matrix = new int[Rows, Columns];
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

int[] SumOfRows(int[,] matrix)                           // Функция вычесляет сумму элементов по строчно
{
    int[] sum = new int[matrix.GetLength(0)];                 // Массив для хранения результатов
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }
    return sum;
}

void PrintOnedimensionalArray(int[] arrayInput)            // Функция печати одномерного массива
{
    for (int j = 0; j < arrayInput.Length; j++)
    {
        Console.Write($"{arrayInput[j]}\t");
    }
}

int MinIndex(int[] array)                           // Функция нахождения индекса минимального   
{
    int minNumber = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix = FillArray(4, 4);
PrintArray(matrix);
Console.WriteLine();
int[] sum = SumOfRows(matrix);
PrintOnedimensionalArray(sum);
Console.WriteLine();
Console.WriteLine($"The smallest sum of elements for a user in {MinIndex(sum) + 1} a row");
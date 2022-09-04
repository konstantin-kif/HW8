// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArray(int Rows, int Columns)                           // Функция создания и заполнения двухмерного массива
{
    int[,] matrix = new int[Rows, Columns];
    for (int i = 0; i < matrix.GetLength(0); i++)                                  // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)                              // столбец
        {
            matrix[i, j] = new Random().Next(0, 10);                                 //  числа от 0 до 10
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
            Console.Write("{0}", matrix[i, j]);
           
        }
        Console.WriteLine();
    }
}

int[,] BubbleSortingOfRows(int[,] matrix)                           // Функция выполняет пузырковую сортировку строк по убыванию
{
    for (int i = 0; i < matrix.GetLength(0); i++)                            // строка
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)                   // количество проходов
        {
            bool FlagSort = true;                                           // Флаг готовой сортировки сроки
            for (int j = 0; j < matrix.GetLength(1) - 1 - k; j++)           // Передвижение внури строки
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                    FlagSort = false;
                }
            }
            if (FlagSort) { break; }
        }

    }
    return matrix;
}

int[,] array = FillArray(3, 4);
PrintArray(array);
Console.WriteLine();
int[,] answer = BubbleSortingOfRows(array);
PrintArray(answer);

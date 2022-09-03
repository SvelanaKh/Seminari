// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] GetArray(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().NextDouble() * 20 - 10;
//         }
//     }
//     return matrix;
// }
// double[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);

// void PrintArray(double[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(inputMatrix[i, j], 1) + "\t");
//         }
//         Console.WriteLine();
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }

// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);

// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }


// Console.Write("Введите строку искомого элемента: ");
// int pos1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбец искомого элемента: ");
// int pos2 = Convert.ToInt32(Console.ReadLine());

// if (pos1 < 0 | pos1 > inputMatrix.GetLength(0) - 1 | pos2 < 0 | pos2 > inputMatrix.GetLength(1) - 1)
//             {
//                 Console.WriteLine("Элемент не существует");
//             }
//             else
//             {
//                 Console.WriteLine("Значение элемента массива = {0}", inputMatrix[pos1, pos2]);
//             }
//             Console.ReadLine();
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам
{
    // i, j, m, k
    for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("---------------------------");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{Math.Round(sum / matrix.GetLength(0), 1)} \t ");
}
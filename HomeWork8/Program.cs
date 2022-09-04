// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[rows, columns];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine("");
//     }
// }
// FillArray(numbers);
// Console.WriteLine();

// PrintArray(numbers);

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         for (int k = 0; k < numbers.GetLength(1) - 1; k++)
//         {
//             if (numbers[i, k] < numbers[i, k + 1]) 
//             {
//                 int temp = numbers[i, j];
//                 numbers[i, k] = numbers[i, k + 1];
//                 numbers[i, k + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив с упорядоченными значениями");
// PrintArray(numbers);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[rows, columns];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine("");
//     }
// }
// FillArray(numbers);
// Console.WriteLine();

// PrintArray(numbers);


// int minsum = Int32.MaxValue;
// int numberLine = 0;

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         sum = sum + numbers[i, j];        
//     }
//     if (sum < minsum)
//     {
//         minsum = sum;
//         numberLine = i + 1;
//     }

// }
// Console.WriteLine($"номер строки с наименьшей суммой елементов:  {numberLine} , с суммой елементов равной:  {minsum}");




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrixA = new int[rows, columns];
// int[,] matrixB = new int[rows, columns];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine("");
//     }
// }
// FillArray(matrixA);
// FillArray(matrixB);
// Console.WriteLine("Матрица А");
// PrintArray(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица В");
// PrintArray(matrixB);
// Console.WriteLine();

// int[,] matrixC = new int[rows, columns];

// for (int i = 0; i < matrixC.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixC.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrixC.GetLength(0); k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Произведение");
// PrintArray(matrixC);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("введите размерность 1");
int dimensions1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размерность 2");
int dimensions2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размерность 3");
int dimensions3 = Convert.ToInt32(Console.ReadLine());

int[,,] matrix3D = new int[dimensions1, dimensions2, dimensions3];
void FillArray3D(int[,,] array)

{
    int start = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = start;
                start++;
            }
        }
    }
}
FillArray3D(matrix3D);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

PrintArray(matrix3D);
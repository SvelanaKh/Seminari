//Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()!);

// int[,] matrix = new int[rows, columns];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     // i, j, m, k
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(11);
//     }
// }
// void ChangeLines(int[,] matrix)
// {
//     int lastIndex = matrix.GetLength(0);
//     for (int j = 0; j < lastIndex; j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[lastIndex - 1, j];
//         matrix[lastIndex - 1, j] = temp;
//     }
// }
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(matrix);
// ChangeLines(matrix);
// Console.WriteLine();
// PrintArray(matrix);



// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это не
// возможно, программа должна вывести сообщение для
// пользователя.

// Console.WriteLine("Введите колличество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] MakeRandArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//         }
//     }
//     return matrix;
// }

// void TurnOverArray(int[,] matrix, int m, int n)// можно войд
// {
//     for (int j = 0; j < m; j++)
//     {
//         for (int i = j; i < n; i++)
//         {
//             int row = matrix[j, i];
//             matrix[j, i] = matrix[i, j];
//             matrix[i, j] = row;
//         }
//     }
// }

// int[,] MakeTurnOverArray(int[,] oldMatrix, int m, int n)
// {
//     int[,] matrix = new int[n, m];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[j, i] = oldMatrix[i, j];
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix, int m, int n)
// {
//     Console.WriteLine("\n\n");
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Array = MakeRandArray(rows, columns);
// PrintArray(Array, rows, columns);

// if (rows == columns)
// {
//     TurnOverArray(Array, rows, columns);
//     PrintArray(Array, rows, columns);
// }
// else
// {
//     int[,] turnOverArray = MakeTurnOverArray(Array, rows, columns);
//     PrintArray(turnOverArray, columns, rows);//интересный момент нужно написать строки и столбцы наоборот потому что массив у нас на боку: {Ленивый массив}
// }


// Задача 57: Составить частотный словарь элементов двумерного
// массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

Console.Clear();

Console.WriteLine("Введите максимальное диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MakeRandArray(int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void FindCountAndPrint(int[,] matrix, int rows, int columns, int max, int min)
{

    Console.WriteLine();
    for (int i = 0; i < max - min; i++)
    {
        int count = 0;
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                if (matrix[j, k] == min + i) count++;
            }
        }
        Console.WriteLine($"{min + i}: встречается {count} раз");
    }
}

void PrintArray(int[,] matrix, int m, int n)
{
    Console.WriteLine("\n\n");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Array = MakeRandArray(rows, columns, max, min);
PrintArray(Array, rows, columns);
FindCountAndPrint(Array, rows, columns, max, min);


// Задача 59: Задайте двумерный массив из целлых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива

int rows = 3;
int columns = 3;
int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int minElementRow = 0; // Строчка с минимальным элементом
int minElementColumn = 0;// Столбец с минимальным элементом
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = rows
{
    for (int j = 0; j < columns; j++) // matrix.GetLength(1) = columns
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t"); // Tab
        if (minElement > matrix[i, j]) // 5 > 0 , min = 0
        {
            minElement = matrix[i, j];
            minElementRow = i;
            minElementColumn = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Min = {minElement}, row: {minElementRow}, column: {minElementColumn} ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (minElementRow != i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minElementColumn != j)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}


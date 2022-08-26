// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int [] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write($"{array[i]}  ");
// }
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0) count = count + 1;
    
// }
// Console.Write($"четных элементов {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 11);
//     Console.Write($"{array[i]}  ");
// }
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 == 1)
//      {
//         sum = sum + array[i];
//      }
// }
// Console.WriteLine($"сумма элементов нечетных позиций {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write($"{array[i]}  ");
}
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    else if (array[i] > max) max = array[i];
}
double dif = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом = {dif}");
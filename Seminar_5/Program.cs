// адача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



// int[] array = new int[12]; // array = [0,0,0...,0]

// int resultNegative = 0; // sumNegative (-)
// int resultPositive = 0; // sumPositive (+)

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(-9,10); // [-9;10)
// // отрицательное число: array[i] < 0 , то число отрицательное
// if (array[i] < 0) resultNegative += array[i]; // resultNegative = resultNegative + array[i]
// else resultPositive += array[i]; // resultPositive = resultPositive + array[i]
// }

// Console.WriteLine($"[ {String.Join(" ,", array)} ]");
// Console.WriteLine($"sumNegative: {resultNegative}, sumPositive: {resultPositive}");



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = { -2, -1, 0, 1, 2 };

for (int i = 0; i < array.Length; i++)
{
// array[i] *= (-1);
array[i] = -array[i];
Console.Write(array[i] + " ,");
}


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] array = {6,7,19,345,3};

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool pos = false;

// for (int i = 0; i < array.Length; i++)
// {
// if (num == array[i])
// {
// pos = true;
// break;
// }
// }

// if (pos == true) Console.WriteLine("Число " + num + " есть в массиве");
// if (pos == false) Console.WriteLine("Числа " + num + " НЕТ в массиве");


int[] array = { -2, -1, 0, 1, 2 };

int findNumber = 22;

bool flagResult = false; // bool = false,true
// flagResult = false - element not found
// flagResult = true - element found

for (int i = 0; i < array.Length; i++)
{
if (findNumber == array[i])
{
flagResult = true;
break; // ломает цикл - цикл останавливается
}
}
// 1 - true, 0 - false
if (flagResult) Console.WriteLine("Element found"); // flagResult == true -> if (flagResult)
else Console.WriteLine("Element NOT found");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = { -2, -1, 0, 1, 2, 19, 95,22 };
// [10;99]
int count = 0; // количество чисел, которые лежат в диапазоне [10;99]
int size = array.Length;

for (int i = 0; i < size; i++)
{
if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");
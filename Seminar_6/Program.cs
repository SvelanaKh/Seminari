// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// // Лучше вынести размер массива в отдельную переменную
// for (int i = 0; i < size; i++) // size = array.Length
// {
// array[i] = new Random().Next(11); //[0;10]
// Console.Write(array[i] + "\t"); // "\t" = tab
// }

// // 1 способ: поэлементо скопировать в новый массив
// // Копируем не слево направо, а справа налево
// Console.WriteLine();
// Console.WriteLine("Результат:");
// int [] resultArray = new int[size];
// int lastIndex = size - 1;
// for (int i = 0; i < size; i++)
// {
// resultArray[i] = array[lastIndex - i];
// Console.Write(resultArray[i] + "\t");
// }




// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=CopyArray(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray(array);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];
// for (int i = 0; i < size; i++) // size = array.Length
// {
// res[i] = new Random().Next(minValue, maxValue + 1); // [0,5) => [0;4]
// }
// return res;
// }

// void ReversArray(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int temp = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = temp;
// }
// }

// int[] CopyArray(int[] inArray)
// {
// int[] result = new int[inArray.Length]; // size = inArray.Length
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];

// }
// return result;
// }




// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int a = 3;
int b = 4;
int c = 5;
if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник НЕ существует");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int countFibonacci = 10; // Количество чисел Фибоначчи
int firstElement = 0; // 1 число, i = 1
int secondElement = 1; // 2 число, i = 2
Console.WriteLine(firstElement);
Console.WriteLine(secondElement);
// i = 3
for (int i = 3; i <= countFibonacci; i++)
{
int nextElement = firstElement + secondElement;
// nextElement = 0 + 1; nextElement = 1
Console.WriteLine(nextElement);
firstElement = secondElement;
secondElement = nextElement;
}
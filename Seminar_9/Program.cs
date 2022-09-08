

int number = Convert.ToInt32(Console.ReadLine());
int Factotial(int number)
{
// Базовый случай - выход из рекурсии
if (number == 1) return 1;
// Рекурсивный случай - вызов функции, организация рекурсии
return (number * Factotial(number -1));
}
Console.WriteLine($"Факториал от числа {number} = {Factotial(number)}");


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int N = Convert.ToInt32(Console.ReadLine());
/// start = начало (1), end - конец (N)
string PrintNumbers(int start, int end)
{
// Базовый случай
if (start == end) return start.ToString(); // start == end (start == N), возращаем число
// Рекурсивный случай
return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine($"Числа от 1 до {N}: '{PrintNumbers(1, N)}' ");



// Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// start = начало (1), end - конец (N)
if (M > N) return; // Останавливаем работу программы
string PrintNumbers(int start, int end)
{
// Базовый случай
if (start == end) return start.ToString(); // start == end (start == N), возращаем число
// Рекурсивный случай
return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine($"Числа от 1 до {N}: '{PrintNumbers(M, N)}' ");




// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = Convert.ToInt32(Console.ReadLine());
// 45 -> 5
// 4
int SumNumbers(int num)
{
// Базовый случай
if (num == 0) return 0; // sum + 0 = sum
// Рекурсивный случай
return (num % 10 + SumNumbers(num / 10));
}

Console.WriteLine($"Сумма цифр в числе {number} = {SumNumbers(number)}");


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
/// number - A, power - B => A^(B)
int Power(int number, int power)
{
// Базовый случай
if (power == 0) return 1;
if (power == 1) return number;
// Рекурсивный случай
return (number * Power(number, power - 1));
}

Console.WriteLine($"Число {number} в степень {degree} = {Power(number,degree)}");
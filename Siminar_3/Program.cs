// 17. Напишите программу, которая принимает на 
// вход координаты точки (X и Y), причём X ≠ 0 и 
// Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату по оси х: ");
// int x = int.Parse(Console.ReadLine());
// // Parse конвертирует только в Int
// // null обрабатывается в Convert.ToInt32(), предупреждения нет
// Console.WriteLine("Введите координату по оси у: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("I четверть");
// if (x < 0 && y > 0) Console.WriteLine("II четверть");
// if (x < 0 && y < 0) Console.WriteLine("III четверть");
// if (x > 0 && y < 0) Console.WriteLine("IV четверть");


// Задача 18: Напишите программу, которая по заданному 
// номеру четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// if (quarter < 1 || quarter > 4) {Console.WriteLine("Ошибка");}

// if (quarter == 1) Console.WriteLine("x > 0 и y > 0");
// if (quarter == 2) Console.WriteLine("x < 0 и y > 0");
// if (quarter == 3) Console.WriteLine("x < 0 и y < 0");
// if (quarter == 4) Console.WriteLine("x > 0 и y < 0");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату Точки А по оси х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки А по оси y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки B по оси х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки B по оси y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double x = Math.Pow((x2 - x1), 2);
// double y = Math.Pow((y2 - y1), 2);
// double d = Math.Sqrt(x + y);
// Console.WriteLine($"расстояние между точками: {Math.Round(d,3)}"); //Math.Round(d,3) оператор округления или {d:f3}  result "обрезается" до 3 знаков после запятой


// Задача 22: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++)
// {
//     Console.Write(Math.Pow(i, 2) +"\t");
// }
//или
int i = 1;
while (i <= num)
{
    Console.WriteLine(Math.Pow(i, 2) + "\t");
    i++;
}


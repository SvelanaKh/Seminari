// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine();
// if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine("да");
// else Console.WriteLine("нет");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координату Точки А по оси х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки А по оси y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки А по оси z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки B по оси х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки B по оси y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Точки B по оси z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double dim = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// Console.WriteLine($"расстояние между точками: {Math.Round(dim, 3)}");



// Задача 23 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 3) +"\t");
}
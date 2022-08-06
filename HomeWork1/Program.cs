// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber > secondNumber * secondNumber)
// {
//     Console.WriteLine("max = " + firstNumber);
// }
// else
// {
//     Console.WriteLine("max = " + secondNumber);
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// int max = firstNumber;
// if (secondNumber > max) max = secondNumber;
// if (thirdNumber > max) max = thirdNumber;
// Console.WriteLine("max = " + max);




// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// if (Number %2 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 1)
{

    int Number1 = 2;
    while (Number1 <= Number)
    {
        Console.WriteLine(Number1);
        Number1 = Number1 + 2;
    }
}
else
{
    Console.WriteLine("Eror 404");
}    
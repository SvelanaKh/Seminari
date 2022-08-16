// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine("Результат: " + square);



// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine(firstNumber + " явялется квадратом от " + secondNumber);
// }
// else
// {
//     Console.WriteLine(firstNumber + " НЕ явялется квадратом от " + secondNumber);
// }


// int DayNumber = Convert.ToInt32(Console.ReadLine());
// if (DayNumber == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// и т.д.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number<0)
// {
//     number = number * (-1);
// }
// int negativNumber = number * (-1);

// while (negativNumber <= number)
// {
//     Console.WriteLine(negativNumber);
//     negativNumber++; //++ увеличить на единицу
// }




// Второй семинар
// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int number = new Random().Next(10,100); //[10; 99]
// //Console.WriteLine("Рандомное число: " + number); // Конкатенация - процесс сложения строк
//     //Console.WriteLine($"Рандомное число: {number}");         // Интерполяция 
// int firstDigit = number / 10;      // "/" - деление без остатка
// int secondDigit = number % 10;       // "% 10"  - остаток от деления на 10

// int maximum = firstDigit;      // Пусть максимум - первое число
// if (secondDigit > maximum) maximum = secondDigit;
// Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");



//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

// int number = new Random().Next(100,1000); //[100; 1000]
// //Console.WriteLine("Рандомное число: " + number); // Конкатенация - процесс сложения строк
// Console.WriteLine($"Рандомное число: {number}");         // Интерполяция 
// int firstDigit = number / 100;      // "/" - деление без остатка
// int thirdDigit = number % 10;       // "% 10"  - остаток от деления на 10

// Console.WriteLine(firstDigit + "" + thirdDigit);



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно


// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// int div = firstNumber % secondNumber;
// if (div == 0) Console.WriteLine("кратно");
// else Console.WriteLine($"Не кратно, остаток {div}");



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//  14 -> нет 46 -> нет 161 -> да

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// int div1 = Number % 7;
// int div2 = Number % 23;
// if (div1 == 0 && div2 == 0) System.Console.WriteLine("да");
// else System.Console.WriteLine("нет");


// "и" && одновременное выполнение условий
// "или" || выполнение одного из условий




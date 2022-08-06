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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
{
    number = number * (-1);
}
int negativNumber = number * (-1);

while (negativNumber <= number)
{
    Console.WriteLine(negativNumber);
    negativNumber++; //++ увеличить на единицу
}

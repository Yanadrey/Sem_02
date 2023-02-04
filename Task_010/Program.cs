// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number >= 100 && number < 1000)
    System.Console.WriteLine($"Вторая цифра числа: {number / 10 % 10}");
else
    System.Console.WriteLine("Ошибка! Необходимо ввести трехзначное число!");
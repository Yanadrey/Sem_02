// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number >= 0 && number < 100)
    System.Console.WriteLine("У данного числа нет третьей цифры");
else
{
    for (int i = 1; i < number; i = i * 10)
        if (number >= 100 * i && number < 100 * i * 10)
        {
            System.Console.WriteLine($"Третья цифра заданного числа: {number / i % 10}");
            break;
        }
}
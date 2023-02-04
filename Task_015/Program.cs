// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
    System.Console.WriteLine("Такого дня недели не существует");
else
{
    if (number == 6 || number == 7)
        System.Console.WriteLine("Сегодня выходной!");
    else
        System.Console.WriteLine("Сегодня рабочий день");
}
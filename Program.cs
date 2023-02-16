int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
if (number > 7)
{
    Console.WriteLine("Нет такого дня недели!");
}
if (number < 1)
{
    Console.WriteLine("Нет такого дня недели!");
}
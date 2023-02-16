int number, number2;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number2);

if (number == number2 * number2)
{
    Console.WriteLine("Да");
}
if (number != number2 * number2)
{
    Console.WriteLine("Нет");
}
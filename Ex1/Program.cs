// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} - это палиндром");
    }
    else
    {
        Console.WriteLine($"{number} -это НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"Число {number} - не является пятизначным");
}
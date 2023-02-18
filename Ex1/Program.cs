// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputInt(string message)                        
{
    System.Console.Write($"{message} ");
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if(isCorrect)
    { 
        return value;
    }
    System.Console.WriteLine("Вы ввели не число!");
    Environment.Exit(1);
    return 0;
}

int number = InputInt("Введите пятизначное число: ");

if (number < 10000 || number > 99999)
{
    Console.WriteLine($"Число {number} не подходит.Пожалуйста введите другое число!");
}

if ((number/10000 == number%10) && ((number/1000)%10 == (number%100)/10))
{
    Console.WriteLine($"Число {number} является полиндромом,его можно читать слева на право и справа на лево!");
}
else
{
    System.Console.WriteLine($"Число {number} не является полиндромом.");
}

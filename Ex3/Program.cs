// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int InputInt(string message)                        
{
    System.Console.Write($"{message}> ");
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if(isCorrect)
    { 
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int number = InputInt("Введите число N, до которого выдадим кубы: ");

for (int i = 1; i <= number; i++)
{
    int cub = i * i * i;
    System.Console.WriteLine($"{cub} ");
}
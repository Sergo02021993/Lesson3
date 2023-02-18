// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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

double Distance (int x1, int y1,int z1, int x2, int y2,int z2)
{
    int A = x2 - x1;
    int B = y2 - y1;
    int C = z2 - z1;
    return Math.Sqrt (A * A + B * B + C * C);
}

int x1 = InputInt("Введите координату X первой точки: ");
int y1 = InputInt("Введите координату Y первой точки: ");
int z1 = InputInt("Введите координату Z первой точки: ");
int x2 = InputInt("Введите координату X второй точки: ");
int y2 = InputInt("Введите координату Y второй точки: ");
int z2 = InputInt("Введите координату Z второй точки: ");

System.Console.WriteLine($"Расстояние между точкой А({x1},{y1},{z1}) и точкой B({x2},{y2},{z2})  равно {Distance (x1, y1, z1, x2, y2, z2):F2}");
double distance = Distance (x1, y1, z1, x2, y2, z2);

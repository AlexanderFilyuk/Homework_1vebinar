//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой 
//четверти (x и y).


/*

int GetCoordinateFromQuarter(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine("x > 0 и y > 0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine("x < 0 и y > 0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine("x < 0 и y < 0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine("x > 0 и y < 0");
    }
    return quarter;
}
int GetNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int quarter = GetNumberFromUser("Введите четветь: ");
GetCoordinateFromQuarter(quarter);

*/


//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


int GetNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
Double GetDistance (int x1, int y1, int x2, int y2)
{
    double distance = Match.Sqrt(Match.Pow (x2 - x1,2) + Match.Pow(y2 - y1,2));
    return double;
}
int x1 = GetNumberFromUser("Введите x1: ");
int y1 = GetNumberFromUser("Введите y1: ");
int x2 = GetNumberFromUser("Введите x2: ");
int y2 = GetNumberFromUser("Введите y2: ");
int distance = GetDistance (int x1, int y1, int x2, int y2);
Console.WriteLine($"Расстояние между точками = {distance} ");





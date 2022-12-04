//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой 
//четверти (x и y).




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










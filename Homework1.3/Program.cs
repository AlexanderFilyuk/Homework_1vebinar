/* Напишите программу, которая на вход принимает (N), а на выходе показывает все четные числа от 1 до N */

int N = new int();
Console.WriteLine("Введите число");
N = Convert.ToInt32(Console.ReadLine());

int result = 0;
Console.WriteLine("Четные числа");

    while (result < N - 1)
    {
        result +=2;
        Console.WriteLine(result);
    }   




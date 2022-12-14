/* Напишите программу вычисления функции
 Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");

int functionAkkerman = Ack(m, n);

Console.WriteLine($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return Ack(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
    else
    {
        return 404; // ошибка
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}






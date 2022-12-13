/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/



int sumofRange(int start, int finish)
{
    int sum = 0;
    for (int i = start; i <= finish; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result; 
}

int userNumber = getNumberFromUser("Введите А для подсчета суммы 1...А");
int sum = SumofRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1..{userNumber} = {sum}");



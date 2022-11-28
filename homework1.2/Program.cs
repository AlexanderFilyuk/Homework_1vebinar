/* напишите программу, которая на вход принимает число и показывает является ли оно четным*/


int userNumber1 = new int();
Console.WriteLine("Введите число");
    userNumber1 = Convert.ToInt32(Console.ReadLine());

int result = userNumber1 % 2;
if  (result == 0)
    Console.WriteLine("Четное");
else    
{Console.WriteLine("Нечетное");}



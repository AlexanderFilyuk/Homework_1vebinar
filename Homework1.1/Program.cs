/* Напишите программу которая на вход принимает три числа, и выдает максимальное*/


int userNumber1 = new int();
int userNumber2 = new int();
int userNumber3 = new int();
Console.WriteLine("Введите числа");

    userNumber1 = Convert.ToInt32(Console.ReadLine());
    userNumber2 = Convert.ToInt32(Console.ReadLine());
    userNumber3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
    
{
    if(userNumber1 > max) max = userNumber1;
    if(userNumber2 > max) max = userNumber2;
    if(userNumber3 > max) max = userNumber3;
    
}

Console.WriteLine(max);
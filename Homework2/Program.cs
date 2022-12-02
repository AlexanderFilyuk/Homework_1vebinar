/* : Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/




int userNumber1 = new int();
Console.WriteLine("Введите число");
userNumber1 = Convert.ToInt32(Console.ReadLine());



if  (userNumber1 == 6) 
{
    Console.WriteLine("Выходной");
    return;
}

if (userNumber1 == 7)
{
    Console.WriteLine("Выходной");
}
else    
{
   Console.WriteLine("Нет");
}
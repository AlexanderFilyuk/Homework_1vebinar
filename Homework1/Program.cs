/* напишите программу, которая на вход принимает два числа и выдает, какое число меньше а какое больше */


int userNumber1 = new int();
int userNumber2 = new int();
Console.WriteLine("Введите два числа");

    userNumber1 = Convert.ToInt32(Console.ReadLine());
    userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
{
    Console.WriteLine("{0} наибольшее число", userNumber1);
    Console.WriteLine("{0} наименьшее число", userNumber2);
}

else
{
    Console.WriteLine("{0} наибольшее число", userNumber2);
    Console.WriteLine("{0} наименьшее число", userNumber1);
}


Console.ReadLine();


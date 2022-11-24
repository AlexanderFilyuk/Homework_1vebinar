/*  Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/

int userNumber1 = new int();
Console.WriteLine("Введите число");
int userNumber2 = new int();
Console.WriteLine("Введите число");
userNumber1 = Convert.ToInt32(Console.ReadLine());
int result = userNumber1 * userNumber1;
Console.WriteLine(result);
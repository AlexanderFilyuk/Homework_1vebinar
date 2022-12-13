/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/


int getNumberOfDigits(int number)
{
    int numberOfDigits = 0;
    while(number > 0)
    {
        number = number / 10;
        numberOfDigits = numberOfDigits + 1;
        Console.WriteLine(number);
    }
    return numberOfDigits;
}
int getNumberFromUsers(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int userNumber = getNumberFromUsers("Ввеедите число");
int numberOfDigits = getNumberOfDigits(userNumber);
Console.WriteLine($"Количество цифр в числе {userNumber} = {numberOfDigits}");











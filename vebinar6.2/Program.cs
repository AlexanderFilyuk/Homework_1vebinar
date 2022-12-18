/*  Напишите программу, которая будет преобразовывать
 десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/


int inputUserNumber(string userMessage)
{
    Console.WriteLine(userMessage);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
string transformationNumber(int number)
{
    int buf = 0;
    string result = "";
    while(number > 0)
    {
        buf = number % 2;
        result = buf + result;
        number /= 2; 
    }
    return result;
}
int userNumber = inputUserNumber("Введите число ");
string binaryNumber = transformationNumber(userNumber);
Console.WriteLine(binaryNumber);





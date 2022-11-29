/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

/*
int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start,end + 1);
    return result;
}
int threeDigitNumber(int number)        
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int intEnd = firstDigit * 10 + thirdDigit;
    
    return intEnd;
}

int randomNumber = GetRandomNumberInRange(100, 999);
int maxDigit = threeDigitNumber (randomNumber);

Console.WriteLine($"Трехзначное число {randomNumber} является двухзначным {maxDigit}");

*/




/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/


int userNumber1 = new int();
Console.WriteLine("Введите первое число");
userNumber1 = Convert.ToInt32(Console.ReadLine());

int userNumber2 = new int();
Console.WriteLine("Введите второе число");
userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 % userNumber2 == 0)
{
    Console.WriteLine("Кратно");
}
else 
   {
    int a = userNumber1 % userNumber2;
    Console.WriteLine($"Не кратно, остаток {a} ");
   }






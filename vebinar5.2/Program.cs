/* Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] generateRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    } 
    return resultArray;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}
int userNumber = new int();
int findUserNumberInArray(int userNumber, int[] array)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == userNumber)
        {
            index = i;
            break;
        }
    }
    return index;
}
int[] array = generateRandomArray(10, 1, 100);
printArray(array);
Console.WriteLine();
Console.WriteLine("Введите число ");
userNumber = Convert.ToInt32(Console.ReadLine());
int index = findUserNumberInArray(userNumber, array);
if (index >= 0)
{
    Console.WriteLine($"Число {userNumber} находится в массиве под индексом {index}.");
}

else
{
    Console.WriteLine($"Числа {userNumber} в массиве нет.");
}

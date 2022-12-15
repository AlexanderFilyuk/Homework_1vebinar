/* Задайте одномерный массив из 123 случайных чисел. Найдите
 количество элементов массива, значения которых 
лежат в отрезке [10,99].
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

int findCountElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <=99)
        {
            count = i;
        }
    }
    return count;
}
int[] array = generateRandomArray(10, 1, 150);
printArray(array);
Console.WriteLine();
int count = findCountElement(array);
if (count > 0)
{
    Console.WriteLine($"Число таких элементов = {count}.");
}
else
{
    Console.WriteLine($"Таких элементов нет.");
}




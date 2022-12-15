/*  Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные,
 и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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


void printArray(int[] array, string nameOfArray)
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
int[] inverseArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        array[i] = -array[i];    // меняем знак элемента
    }
    return array;
}
int[] array = generateRandomArray(10,-100,100);
printArray(array,"Исходный массив");
int[] investeArray = inverseArray(array);
printArray(investeArray, "Измененный массив");






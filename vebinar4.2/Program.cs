/*Напишите программу, которая принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

/*

Console.Write("Введите число ");
string writen = Console.ReadLine();
int N = Convert.ToInt32(writen);

int GetFactorial(int N)
{
    int i = 1;
    for (int num = 1; num <= N; num++)
    {
        i = i * num;
    }
    return i;
}
Console.WriteLine($"Произведение чисел от 1 до {N} = {GetFactorial(N)}");
Console.WriteLine();

*/


/*Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/


int N = 8;
int min = 0;
int max = 1;

int [] CreatArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr [i] = new Random().Next(min, max + 1);
    }
    return arr;

}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] array = CreatArray(N, min, max);
PrintArray(array);



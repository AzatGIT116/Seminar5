/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20. */

int SumNumbersParametric(int[] array, bool finPositiveNumbers = true)
{
    int sum = 0;
    foreach (int element in array)
    {
        sum += finPositiveNumbers ? (element >0 ? element : 0):(element <0? element :0);
    }
    return sum; 
}
int[] GetArray( int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray( int[] array)
{
    Console.WriteLine(string.Join(", ", array)); 
}
int[] array = GetArray(12, -9,9);
PrintArray(array);
Console.WriteLine($"Sun pos : {SumNumbersParametric(array)}");
Console.WriteLine($"Sun neg : {SumNumbersParametric(array, false)}");
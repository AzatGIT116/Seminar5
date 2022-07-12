/*  Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

int[] ourArray = { 5, -5, 6, 4 };
CheckIfNumberinArray(ourArray, 4);
void CheckIfNumberinArray(int[] array, int number)
{
    foreach (var item in array)
    {
        if (item == number)
        {
            Console.WriteLine($"The number {number} is in thes array");
            return;
        }
    }
    Console.WriteLine($"the number {number} is NOT in this array");
}
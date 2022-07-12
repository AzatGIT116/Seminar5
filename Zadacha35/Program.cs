/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */
Console.Clear();
int size = 123;
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(200);
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] <= 99 && array[i] >= 10)
        count++;
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine(count);


/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */
Console.Clear();
int[] array = new int[4] { -4, -8, 8, 2 };
void ChangeSignArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}
ChangeSignArray(array);
Console.WriteLine(string.Join(", ", array));

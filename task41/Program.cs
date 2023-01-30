// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* СЕМИНАР_6
ЗАДАЧА_41: пользователь вводит с клавиатуры М числа. Посчитайте, сколько чисел больше 0 ввёл пользователь
0,7,8,-2,-2 -> 2
1,-7,567,89,223 -> 3 */

Console.Clear();
Console.Write("Давайте напишем несколько целых чисел. Сколько вы хотите? - ");
int size = Convert.ToInt32(Console.ReadLine());

int[] Massive(int size) //создаем массив цифр, которые пользователь вводит сам
{
    int[] array = new int[size];
    Console.WriteLine("введите любое целое число:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    //Console.WriteLine($"соберем в кучку: " + string.Join("; ", array)); // можно ввести строку для отображения данных в строку
    return array;
}
int[] result = Massive(size); 

int CountPositive (int [] array) // запускаем функцию для перебора каждого занчения в массиве
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) count ++;
    }
    return count;
}
Console.WriteLine($"количество положительных чисел равно = {CountPositive(result)}");
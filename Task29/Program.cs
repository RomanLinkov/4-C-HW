// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int lngth = NumberInput("Введите длину массива: ");
int min = NumberInput("Введите минимальный элемент массива: ");
int max = NumberInput("Введите максимальный элемент массива: ");

int[] nums = ArrayGeneration(lngth, min, max);

Console.Write($" -> [{String.Join(", ", nums)}]");
Console.WriteLine();

int[] ArrayGeneration(int lngth, int min, int max)
{
    Console.WriteLine("Генерируемый массив: ");
    int[] array = new int[lngth];
    for (int i = 0; i<lngth;i++)
    {
        int value = new Random().Next(min,max+1);
        array[i] = value;
        Console.Write($"{value}");
        if (i<lngth-1) Console.Write($", ");
    }
    return array;
}

int NumberInput(string msg)

{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
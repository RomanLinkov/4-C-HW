// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int lngth = NumberInput("Введите длину массива: ");
int min = NumberInput("Введите минимальный элемент массива: ");
int max = NumberInput("Введите максимальный элемент массива: ");

int[] nums = ArrayGeneration(lngth, min, max);


Console.WriteLine("Генерируемый массив: ");
PrintArray(nums);
Console.Write(" -> [");
PrintArray(nums);
Console.WriteLine($"]");

void PrintArray(int[] a)
{
    
    for (int i=0; i<a.Length;i++)
    {
        Console.Write($"{a[i]}");
        if (i<a.Length-1)Console.Write($", ");
    }
    
}

int[] ArrayGeneration(int lngth, int min, int max)
{
    int[] array = new int[lngth];
    Random rand = new Random();
    for (int i = 0; i<lngth;i++)
    {
        int value = rand.Next(min,max+1);
        array[i] = value;
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
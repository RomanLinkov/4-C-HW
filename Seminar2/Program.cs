Console.Clear();

int lngth = NumberInput("Введите длину массива: ");

int[] nums = ArrayGeneration(lngth, 0, 2);

Console.WriteLine("Генерируемый массив: ");
PrintArray(nums);


void PrintArray(int[] a)
{
    Console.Write("[");
    for (int i=0; i<a.Length;i++)
    {
        Console.Write($"{a[i]}");
        if (i<a.Length-1)Console.Write($", ");
    }
    Console.WriteLine($"]");
}

int[] ArrayGeneration(int lngth, int min, int max)
{
    int[] array = new int[lngth];
    for (int i = 0; i<lngth;i++)
    {
        int value = new Random().Next(min,max);
        array[i] = value;
        //Console.Write($"{value}");
        //if (i<lngth-1) Console.Write($", ");
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
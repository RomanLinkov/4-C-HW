# 4-C-HW
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Сколько эллементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = NewRandomArray(num, 0, 10);
Console.WriteLine($"Полученый массив из {num} эллементов");
PrintArray(arr);

//Методы
int[] NewRandomArray(int num, int min, int max)
{
   /*  Random rand = new Random(); */
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Короче

int[] NewRandomArray(int num, int min, int max)
            {
                Random rand = new Random();
                int[] arr = new int[num];
                for (int i = 0; i < num; i++)
                {
                    arr[i] = rand.Next(min, max + 1);
                }
                return arr;
            }
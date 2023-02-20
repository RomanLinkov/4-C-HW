// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

int numA = NumberInput("Введите число: ");
int powNumA = NumberInput("Введите степень этого числа: ");
PowerOutput(numA, powNumA);

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double PowerNumber(int a, int b)
{
    double result = Math.Pow(a,b);
    return(result);
}

void PowerOutput(int a, int b)
{
    Console.WriteLine($"{a}, {b} -> {PowerNumber(a,b)}");
}
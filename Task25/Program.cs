// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

int numA = NumberInput("Введите число: ");
int powNumA = NumberInput("Введите степень этого числа: ");

bool b=true;

while (b)
{
    powNumA = NumberInput("Степень должна быть натуральным числом, повторите ввод степени: ");
    if (powNumA<1) b=true;
    else break;
}

double result=PowerNumber(numA,powNumA);

PowerOutput(numA,powNumA, result);

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double PowerNumber(int a, int b)
{
    if (b==0) return 1;
    else
    {
    double result = a;
    for(int i=1;i<b;i++)
    {
        result=result*a;
    }
    return(result);
    }
}

void PowerOutput(int a, int b, double x)
{
    Console.WriteLine($"{a}, {b} -> {x}");
}
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int num = NumberInput("Введите число: ");

DigitSumOutput(num);

int SumDigit(int x)
{
    int sum=0;
    int digit=0;
    while (x > 0)
    {
        digit = x % 10;
        sum=sum+digit;
        x/=10;
    }
    return(sum);
}

int NumberInput(string msg)

{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void DigitSumOutput(int a)
{
    Console.WriteLine($"{a} -> {SumDigit(a)}");
}


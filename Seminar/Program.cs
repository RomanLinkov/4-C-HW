Console.Clear();

int num = NumberInput("Введите число: ");

int factorial = Factorial(num);

OutputResult("Факториал введённого числа: ", factorial);

void OutputResult(string msg, int b)
{
    Console.WriteLine($"{msg} {b}");
}

int Factorial(int a)
{
    int result=1;
    int i=1;
    checked;
    while (i<a)
    {
        i++;
        result = result*i;
       // Console.WriteLine(result);
    }
    return result;
}

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int ForPower(int num1, int num2)
{   
    int result = 1;
    if(num1 == 0 && num2 == 0)
    {
        return result; 
    }
    else
    {
        for(int count = 0; count < num2; count++)
    {
        result *= num1;
    }
    return result;
    }
}

Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write(ForPower(num1, num2));

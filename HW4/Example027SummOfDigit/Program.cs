int SummOfDigit(int num)
{
    int result = 0;
    while(num / 10 != 0)
    {
        result += num % 10;
        num = num / 10;
    }
    result += num;
    return result;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write(SummOfDigit(num));

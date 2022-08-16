Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int DigitCount(int a)
{
    int count = 0;
    while(a != 0)
    {
        count++;
        a /= 10;
    }
    return count;
}

Console.Write(DigitCount(num));
Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());

int GetBinary(int num)
{
    string result = String.Empty;
    while(num > 0)
    {
        result = result + num % 2;
        num /= 2;
    }

    result.ToCharArray().Reverse();

    return int.Parse(result);
}

Console.Write($"{GetBinary(number)}");

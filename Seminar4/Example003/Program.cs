Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int MultiOf(int a)
{
    int count = 2;
    int result = 1;
    while(count <= a)
    {
        result *= count;
        count++;
    }
    return result;
}

Console.Write(MultiOf(num));
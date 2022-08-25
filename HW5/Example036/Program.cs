int[] GetArray(int size, int start, int end)
{
    int[] ResultArray = new int[size];
    Random random = new Random();
    for(int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = random.Next(100, 1000);
    }
    return ResultArray;
}

int GetSummOfOddPossition(int[] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i +=2)
    {
        result += array[i];
    }
    return result;
}

/*Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу для генератора случайных чисел: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу для генератора случайных чисел: ");
int end = int.Parse(Console.ReadLine());*/

//int[] array = GetArray(size, start, end);
int[] array = new int[4];
for(int i = 0; i < array.Length; i++)
{
    Console.Write("введите число: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write(GetSummOfOddPossition(array));
int[] ArrayExist(int count, int start, int end)
{
    int[] resultArray = new int[count];
    Random rnd = new Random();
    for(int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(start, end);
    }
    return resultArray;
}

Console.Write("Введите количество элементов массива: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу для генератора случайных чисел: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу для генератора случайных чисел: ");
int end = int.Parse(Console.ReadLine());
Console.WriteLine("[{0}]", string.Join(", ", ArrayExist(count, start, end)));
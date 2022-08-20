int[] GetArray(int size, int start, int end)
{

    int[] resultArray = new int[size];
    Random random = new Random();

    for(int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(start, end + 1);
    }

    return resultArray;

}

void GetSummOfArray(int[] array)
{

    int summOfPositive = 0;
    int summOfNegative = 0;
    foreach(int el in array)

    {
        summOfPositive += el > 0 ? el : 0;
        summOfNegative += el < 0 ? el : 0;
    }
    Console.Write($"Сумма положительных чисел в массиве равна: {summOfPositive}, а сумма отрицательных значений равна: {summOfNegative}");

}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу для генератора случайных чисел: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу для генератора случайных чисел: ");
int end = int.Parse(Console.ReadLine());

int[] array = GetArray(size, start, end);
GetSummOfArray(array);
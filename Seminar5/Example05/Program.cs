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

int[] GetMultiArray(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 == 1)
    {
        size += 1;
    }
    int[] resultArray = new int[size];
    int multi = 0;
    int start = 0;
    int end = array.Length -1;
    while(start < end)
    {
        end = (array.Length - 1) - start;
        multi = array[start] * array[end];
        resultArray[start] = multi;
        start +=1;
    }

    return resultArray;
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу для генератора случайных чисел: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу для генератора случайных чисел: ");
int end = int.Parse(Console.ReadLine());

int[] array = GetArray(size, start, end);
Console.WriteLine(String.Join(" ", array));
array = GetMultiArray(array);
Console.Write("[{0}]", String.Join(", ", array));

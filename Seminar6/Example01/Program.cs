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

/*int[] ArrayReverse(int[] array)
{
    int [] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}*/

int[] ArrayReverse(int[] array)
{
    int buff = 0;
    
    for(int i = 0; i < array.Length / 2; i++)
    {
        buff = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i];
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу для генератора случайных чисел: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу для генератора случайных чисел: ");
int end = int.Parse(Console.ReadLine());

int[] array = GetArray(size, start, end);
Console.WriteLine(String.Join(", ", array));
Console.Write(String.Join(", ", ArrayReverse(array)));
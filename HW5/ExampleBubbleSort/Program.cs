int[] GetArray(int size, int start, int end)
{
    int[] ResultArray = new int[size];
    Random random = new Random();
    for(int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = random.Next(start, end);
    }
    return ResultArray;
}
/*int MaxFind(int[] array)
{
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        
    }
}*/

int[] BubbleSort(int[] array)
{
    int max;
    int buff;
    for(int i = 0; i < array.Length; i++)
    {
        max = array[i];
        buff = i;
        for(int j = i; j < array.Length; j ++)
        {
            if(max < array[j])
            {
                max = array[j];
                buff = j;
            }
        }
        array[buff] = array[i];
        array[i] = max;
    }
    return array;

}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу для генератора случайных чисел: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу для генератора случайных чисел: ");
int end = int.Parse(Console.ReadLine());

int[] array = BubbleSort(GetArray(size, start, end));
Console.WriteLine("[{0}]", String.Join(", ", array));

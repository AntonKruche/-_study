Console.Write("Введите количество значений для ввода: ");
int InputCount = int.Parse(Console.ReadLine());

int[] InitArray(int size)
{
    int[] ResultArray = new int[size];
    for(int i = 0; i < ResultArray.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        ResultArray[i] = int.Parse(Console.ReadLine());
    }
    return ResultArray;
}

int CountOfPositiveInput(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

int [] array = InitArray(InputCount);
Console.Write(CountOfPositiveInput(array));
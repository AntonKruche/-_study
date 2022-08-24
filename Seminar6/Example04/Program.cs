int[] GetFiboNum(int count)
{
    int[] result = new int[count];
    result[0] = 0;
    result[1] = 1;
    for(int i = 2; i < result.Length; i++)
    {   
        result[i] = result[i-1] + result[i-2];
        //Console.WriteLine(result[i]);
    }
    return result;
}

Console.Write("Введите число: ");
int countOf = int.Parse(Console.ReadLine());

int[] array = GetFiboNum(countOf);
Console.WriteLine("{0}", String.Join(" ", array));
//Console.Write(String.Join(" ", array));

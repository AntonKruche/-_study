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

void NumberCheck(int[] array, int number)
{
    string answer = "Нет";
    foreach(int el in array)
    {
        answer = el == number ? "Да" : answer;
    }
    /*{
        if(el == number)
        {
            answer = "Да";
            break;
        }

    }*/
    Console.WriteLine(answer);
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу для генератора случайных чисел: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу для генератора случайных чисел: ");
int end = int.Parse(Console.ReadLine());
Console.Write("Введите интересующее число: ");
int MustWantedNumber = int.Parse(Console.ReadLine());

int[] array = GetArray(size, start, end);
Console.WriteLine("[{0}]", String.Join(", ", array));

NumberCheck(array, MustWantedNumber);
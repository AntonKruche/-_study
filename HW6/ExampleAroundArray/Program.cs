int[,] array = new int[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {10,11,12}};

int top = array.GetLength(0) - 1;
int bot = 0;
int right = array.GetLength(1) - 1;
int left = 0;

Console.Write(String.Join(" ", array));

Console.WriteLine($"Количество строк: {array.GetLength(0)}");
Console.WriteLine($"Количество столбиков: {array.GetLength(1)}");
string result = String.Empty;

string AroundArray(int top, int bot, int right, int left)
{
    while(top > bot){
        for(int i = left; i <= right; i++)     //совершаем перебор последней строки
        {                                      
            result += array[top, i] + " ";
        }                                      
        top--;
        //Console.WriteLine(top);

        for(int i = top; i >= bot; i--)
        {
            result+= array[i, right] + " ";
        }

        right--;
        //Console.WriteLine(right);

        for(int i = right; i >= left; i --)
        {
            result += array[bot, i] + " ";
        }

        bot++;

        for(int i = bot; i <= top; i++)
        {
            result += array[bot, left] + " ";
        }

        left++;

        AroundArray(top, bot, right, left);

    }
 

    return result;
}

Console.WriteLine(AroundArray(top, bot, right, left));














































/*
for(int i = 0; i <= right; i++)     //совершаем перебор последней строки
    {                                      
        result += array[top, i] + " ";
    }                                      
top--;

for(int i = top; i >= 0; i--)
{
    result+= array[i, right] + " ";
}

right--;

for(int i = right; i >= 0; i --)
{
    result += array[bot, i] + " ";
}

bot++;

for(int i = bot; i <= top; i++)
{
    result += array[bot, left] + " ";
}

left++;

result += array[1,1];

Console.WriteLine($"{top}, {bot}, {left}, {right}");
Console.WriteLine(result);
 int[] AroundArray(int[,] array)

{
    int CountOfRows = array.GetLenght(0) - 1;
    int CountOfColumns = array.GetLenght(1) - 1;
    string result = String.Empty;
    for(int i = 0; i < CountOfColumn; i++) //совершаем перебор последней строки
    {                                      //совершаем перебор последней строки
        result += array[CountOfRows, i];   //совершаем перебор последней строки
    }                                      //совершаем перебор последней строки

    CountOfRows--;

    for(int i = CountOfRows; i => 0 ; i --)     //совершаем перебор последнего столбика
    {                                           //совершаем перебор последнего столбика                     
        result += array[ i , CountOfColumn];    //совершаем перебор последнего столбика
    }                                           //совершаем перебор последнего столбика             

        CountOfColumn--;

    for(int i = CountOfColumn; i > 0 ; i --)
    {
        result += array[]
    }
}*/
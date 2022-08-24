int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool CheckTriangle(int num1,int num2,int num3)
{
    return num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1;
}

if(CheckTriangle(a ,b , c))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
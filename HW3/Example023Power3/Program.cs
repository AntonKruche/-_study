Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for(double i = 1; i < num; i++){
    Console.Write($"{Math.Pow(i , 3)}, ");
}
Console.Write(Math.Pow(num,3));
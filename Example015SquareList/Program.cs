Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
double a;
for(int count = 1; count < num + 1; count++){
    a = Math.Pow(count, 2);
    Console.Write($"{a}, ");
}
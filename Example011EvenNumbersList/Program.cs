Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 2;
while(count <= number -2){
    Console.Write($"{count}, ");
    count +=2;
}
Console.Write(count);
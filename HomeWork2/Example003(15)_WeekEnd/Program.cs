Console.WriteLine("Введите число");
int number = Math.Abs(int.Parse(Console.ReadLine()));
if(number % 7 == 0 || number % 6 == 0){
    Console.Write("Да");
}
else{
    Console.Write("Нет");
}
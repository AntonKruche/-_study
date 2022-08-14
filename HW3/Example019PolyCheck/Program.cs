Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if(num % 10 == num / 10000){
    num = num / 10;
    num = num % 1000;
    if(num % 10 == num / 100){
        Console.Write("Да");
    }
}
else{
    Console.Write("Нет");
}
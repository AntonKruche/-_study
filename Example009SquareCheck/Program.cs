﻿Console.WriteLine("Введите 2 числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1*num1 == num2 || num2*num2 == num1){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.

645 -> 6

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введите номер задачи: 10,13 или 15:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{

case 10: 
    {
        Console.WriteLine("Введите трехзначное число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        
        if (a>999 || a<100) {Console.Write("Число не трехзначное");} 
            else 
            {
               int sec_num = a/100;
               sec_num = (a - sec_num*100) / 10;
               Console.Write($"Второе число: {sec_num}");
            }
        break;    
    } //Zadacha 10

case 13:
    {
        Console.WriteLine("Введите любое целое число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        
        if (a<100) {Console.Write("Третья цифра слева в заданном числе отсутствует");} 
            else 
            {
               int third_num = a/100;
               third_num = third_num % 10;
               Console.Write($"третье число слева: {third_num}");
            }
       
        break;
    } //Zadacha 13
    
case 15:
    {
        Console.WriteLine("Введите целое число a от 1 до 7:"); int a = Convert.ToInt32(Console.ReadLine());
        
        if (a>0 && a<6) {Console.Write("Число соответствует буднему дню");} 
            else {if (a>5 && a<8) {Console.Write("Число соответствует выходному дню");}} 
        break;    
    } //Zadacha 15

}

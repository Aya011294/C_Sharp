//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int randomNumber = new Random().Next(10,999);
Console.WriteLine(randomNumber);
int a = 99;
if (randomNumber < a)
{
Console.WriteLine( "третьей цифры нет");
}
else 
{
int number = randomNumber % 10;
Console.WriteLine(number);
}

//  Напишите программу, которая 
//  1. на вход принимает число (N), а 
//  2. на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

/* Не совсем верный вариант, в случае ввода нечетного числа,
выводит последнее четное с запятой после него (11 -> 10,)

while (count <= number)
{
    if (count != number && count % 2 == 0) Console.Write(count + ", ");
    else if (count % 2 == 0) Console.Write(count);
    count++;
} */

//Вариант, подсказанный преподавателем, работает для всего корректно
while (count <= number)
{
    if (count < number - 1 && count % 2 == 0) Console.Write(count + ", ");
    else if (count % 2 == 0) Console.Write(count);
    count++;
}
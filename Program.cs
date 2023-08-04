/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью 
рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowNums (int num)
{   
    Console.Write (num+", ");
    if (num>2) ShowNums(num-1);
    if (num==2) Console.Write(1);
}

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumOfEvenNums(int num1, int num2)
{   
    int sum = 0;
    if (num1 < num2)
    {
        sum= num1 + SumOfEvenNums(num1+1, num2);
    }
    else if (num1 > num2)
    {
        sum = num1 + SumOfEvenNums(num1-1, num2);
    }
    else sum=num1;
    return sum;
}
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = SumOfEvenNums(num1, num2);
Console.WriteLine(result);
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/* так и не понял, что такое функция аккермана. Списывать не стал.
Зато честно.


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void Sum_digits(int num)
{
    int num_temp = num;
    while(num_temp > 0)
    {
        sum = sum + num_temp % 10;
        num_temp = num_temp / 10;
    }
}

Sum_digits(number);    
Console.WriteLine($"Сумма цифр числа {number} = {sum}");

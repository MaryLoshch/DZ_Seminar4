Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int SumNumber(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int i = num % 10;
        num = num / 10;
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine($"Ответ: {SumNumber(num)}");
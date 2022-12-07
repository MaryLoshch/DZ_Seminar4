Console.WriteLine("Введите число A:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());

// double result = Math.Pow(numA, numB);
// Console.WriteLine($"Число A в степени B = {result}");

int Stepen(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++) result = result * numA;
    return result;
}
Console.WriteLine($"Число {numA} в степени {numB} равно {Stepen(numA,numB)}");
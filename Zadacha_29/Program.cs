
static void GetArray()
{
    int[] ArrayNum = new int[8];


    for (int i = 0; i < ArrayNum.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}: ");
        ArrayNum[i] = int.Parse(Console.ReadLine());

    }




    Console.WriteLine("Получили массив: ");

    for (int i = 1; i < ArrayNum.Length; i++)
    {
        Console.Write(ArrayNum[i] + " ");
    }


    Console.ReadKey();
}
GetArray();
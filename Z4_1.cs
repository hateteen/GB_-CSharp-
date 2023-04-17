void Zadacha25()
{
    Console.WriteLine("введите число A");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B");
    int b = Convert.ToInt32(Console.ReadLine());
    int step = a;

    for (int i = 1; i < b; i++)
    {
    step = step * a;
    }
    Console.WriteLine("A в степени B равно: " + step);
}

void Zadacha27()
{
    Console.WriteLine("введите число");
    int i = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (i > 0)
    {
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
    }
    Console.WriteLine("сумма всех цифр в числе равна: " + sum);
}

void Zadacha29()
{
    int [] numbers = new int[8];
    Console.Write("[");

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = new Random().Next(0, 11);
        Console.Write(" " + Method (i) + " ");
    }
    Console.Write("]");

    int Method (int a)
    {
        return numbers[a];
    }
}
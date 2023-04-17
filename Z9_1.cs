static void Main(string[] args);
{
    void Zadacha68()
    {
        Console.WriteLine("Введите два положительных числа: M и N.");
        int m = InputInt("Введите M: ");
        int n = InputInt("Введите N: ");
        Console.WriteLine($"A({m}, {n}) = {Number(m, n)}");

        int InputInt(string output)
        {
            Console.Write(output);
            return int.Parse(Console.ReadLine());
        }

        int Number(int m, int n)
        {
            if (m == 0)
                return n + 1;
            if (m > 0 && n == 0)
                return Number(m - 1, 1);
            else
                return Number(m - 1, Number(m, n - 1));
        }
    }

    void Zadacha66()
    {
        Console.WriteLine("Введите начальное число M:");
        int numberM = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите начальное число N:");
        int numberN = int.Parse(Console.ReadLine());

        void GapNumberSum (int numberM, int numberN, int sum)
        {
            if (numberM > numberN) 
            {
                Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
                return;
            }
            sum = sum + (numberM++);
            GapNumberSum(numberM, numberN, sum);
        }

        GapNumberSum(numberM, numberN, 0);
    }

    void Zadacha64()
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        void dz64(int n, int m)
        {
            m++;
            if(m % 3 == 0)
                Console.Write(m + ", ");
            if(m >= n)
                return;
            dz64(n, m);
        }
        dz64(n, m);
    }
}
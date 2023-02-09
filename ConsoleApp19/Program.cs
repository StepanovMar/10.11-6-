int[] x = new int[5];
int[] y = new int[5];
InitArray(x, y);
Square(x, y);

void InitArray(int[] x, int[] y)
{
    for (int i = 0; i < x.Length; i++)
    {
        Console.WriteLine($"Введите координаты {i + 1}-го угла");
        Console.Write($"X{i + 1} = ");
        x[i] = int.Parse(Console.ReadLine());
        Console.Write($"Y{i + 1} = ");
        y[i] = int.Parse(Console.ReadLine());
    }
}

void Square(int[] x, int[] y)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (i == (x.Length - 1))
        {
            sum1 += x[i] * y[0];
            sum2 += y[i] * x[0];
        }
        else
        {
            sum1 += x[i] * y[i + 1];
            sum2 += y[i] * x[i + 1];
        }
    }
    Console.WriteLine($"Площадь фигуры = {(Math.Abs(sum1 - sum2)) / 2}");
}
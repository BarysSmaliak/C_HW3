// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.


int ReadNumber (string argument)
{
    int num;
    Console.WriteLine($"Input natural number: ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It,s not a number");
    }
    return num;
}

void CubeNumber()
{
    int N = ReadNumber("N");
    double Cub = 0;
    for (int i = 1; i < N; i++)
    {
        Cub = Math.Pow(i, 3);
        Console.Write($" {Cub}");
    }
}

CubeNumber();
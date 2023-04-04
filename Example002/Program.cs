// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве

int ReadCoordinate (string argument)
{
    int number;
    Console.WriteLine ($"Input point coordinate {argument}: ");
    while((!int.TryParse(Console.ReadLine(), out number)))
    {
        Console.WriteLine ("It,s not a number");
    }
   return number;
}

double Distance ()
{
    int a = ReadCoordinate("x1");
    int b = ReadCoordinate("y1");
    int c = ReadCoordinate("z1");
    int d = ReadCoordinate("x2");
    int e = ReadCoordinate("y2");
    int f = ReadCoordinate("z2");
    double L = Math.Round(Math.Sqrt
    (Math.Pow(Math.Abs(a-d), 2) + Math.Pow(Math.Abs(b-e), 2) + 
    Math.Pow(Math.Abs(c-f), 2)), 2);
    return L;
}

void Print()
{
    double Dis = Distance();
    Console.WriteLine($"Distance between points - {Dis}");
}

Print();

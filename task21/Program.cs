// Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distAB;
}


Console.WriteLine("введите координаты точки A: ");
Console.Write("Xa: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Za: ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты точки B: ");
Console.Write("Xb: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: ");
int Zb = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(Xa, Ya, Za, Xb, Yb, Zb);
double distanceRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero);
Console.WriteLine(distanceRound);
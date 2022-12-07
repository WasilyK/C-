/* Напишите программу, которая принимает на вход координаты двух точек 
    и находит расстояние между ними в 3D пространстве. */

Console.Write("Enter x1 coordinate: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter y1 coordinate: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter z1 coordinate: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Enter x2 coordinate: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Enter y2 coordinate: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Enter z2 coordinate: ");
int z2 = int.Parse(Console.ReadLine());

/*
*   Попытка использовать лямбда выражения
*   язык очень похож на Java
*   поэтому я позволяю себе такие вещи
*/ 
Console.WriteLine(calcDistance(x1, y1, z1, x2, y2, z2, 
                        (a,b) => Math.Pow(a - b, 2)));

double calcDistance(int x1, int y1, int z1, int x2, int y2, int z2, Func<int, int, double> subCalc) {
    double x = subCalc(x1, x2);
    double y = subCalc(y1, y2);
    double z = subCalc(z1, z2);
    return Math.Pow(x + y + z, 0.5);
}
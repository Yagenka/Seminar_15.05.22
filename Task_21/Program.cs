// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты х для А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты у для А");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z для А");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты х для В");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты у для В");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z для В");
int z2 = Convert.ToInt32(Console.ReadLine());


double GetDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return result;
}

double otvet = GetDistance(x1, y1, x2, y2, z1, z2);
Console.WriteLine("{0:0.00}", otvet);                      // вывод ответа с 2мя цифрами после запятой



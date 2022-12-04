Console.WriteLine("Введите координаты");

Console.Write("X1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 = ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("X2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 = ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
Console.Write($"Расстояние между точками {result}");
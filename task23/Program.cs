
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int Y = 3;
for (int P=1;P<=A;P++)
{;
   double root = Math.Pow(P, Y);
   Console.Write($" {root}");
}
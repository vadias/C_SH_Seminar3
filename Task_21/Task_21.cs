// See https://aka.ms/new-console-template for more information

int[] a;
int[] b;
double distance;

System.Console.WriteLine("Введите координаты точки a:x,y,z");
a = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

System.Console.WriteLine("Введите координаты точки b:x,y,z");
b = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

distance = Math.Sqrt(Math.Pow((a[0]-b[0]), 2) + Math.Pow((a[1]-b[1]), 2) + Math.Pow((a[2]-b[2]), 2));

System.Console.WriteLine("Расстояние");
System.Console.WriteLine(Math.Round(distance, 3));


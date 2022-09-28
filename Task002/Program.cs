//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double result;
int ax, ay, az;
int bx, by, bz;

Console.WriteLine("Введите посследовательность координат: ");
Console.Write("ax: ");
ax = Convert.ToInt32(Console.ReadLine());
Console.Write("ay: ");
ay = Convert.ToInt32(Console.ReadLine());
Console.Write("az: ");
az = Convert.ToInt32(Console.ReadLine());

Console.Write("bx: ");
bx = Convert.ToInt32(Console.ReadLine());
Console.Write("by: ");
by = Convert.ToInt32(Console.ReadLine());
Console.Write("bz: ");
bz = Convert.ToInt32(Console.ReadLine());

result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
result = Math.Round(result, 2);
Console.WriteLine(result);
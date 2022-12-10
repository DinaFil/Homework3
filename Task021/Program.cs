void Condition()
{
Console.WriteLine("Для подсчета расстояния между двумя точками в трехмерном пространстве введите с новой строки координаты xa, ya, za, xb, yb, zb");
}
Condition();

double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());


double AB = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
Console.WriteLine($"Расстояние между точками а и b равно {AB}");

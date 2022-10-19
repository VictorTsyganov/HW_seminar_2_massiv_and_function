// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();

Console.Write("Укажите сколько координат у каждой точки (2D или 3D): ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите координаты первой точки (после ввода каждой координаты необходимо нажать Enter): ");
int[] point1 = new int[n];
for (int i = 0; i < n; i++)
{
    point1[i] = int.Parse(Console.ReadLine());
}

Console.Write("Введите координаты второй точки (после ввода каждой координаты необходимо нажать Enter): ");
int[] point2 = new int[n];
for (int i = 0; i < n; i++)
{
    point2[i] = int.Parse(Console.ReadLine());
}

double result = 0;
for (int i = 0; i < n; i++)
{
    result = result + Math.Pow((point2[i] - point1[i]), 2);
}

Console.WriteLine($"Расстояние между двумя точками равно: {Math.Sqrt(result)} единиц измерения.");
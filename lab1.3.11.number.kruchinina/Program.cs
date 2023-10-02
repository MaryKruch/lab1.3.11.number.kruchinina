Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
int d = n * 30 + 2;
int x = (d % 360) / 30 + 1;
Console.WriteLine($"x равно:{x}");
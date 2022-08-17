// Задача №47:Задайте двумерный массив размером mхn,заполненный случайными вещественными числами.

Console.WriteLine("Задача №47");
Console.WriteLine("Задать размерность массива mхn");
Console.Write("Введи m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
Console.WriteLine("Полученный массив: ");
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        matrix[i, j] = new Random().NextDouble();
        Console.Write(Math.Round(matrix[i, j], 1) + "  ");}
    Console.WriteLine();}
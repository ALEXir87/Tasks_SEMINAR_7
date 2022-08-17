// Задача №52:Задайте двумерный массив из целых чисел.Найдите среднее арифметическое 
// элементов в каждом столбце.

Console.WriteLine("Задача №52");
Console.Write("Введи число строк: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число столбцов: n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillArrayRandomNumbers(matrix);
Console.WriteLine("Исходный массив: ");
PrintArray(matrix);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
for (int j = 0; j < matrix.GetLength(1); j++){
    double rezult = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        rezult = (rezult + matrix[i, j]);}
    rezult = rezult / n;
    Console.Write(Math.Round(rezult, 1) + "; ");}
Console.WriteLine();

void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(0, 10);}}}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");}
        Console.WriteLine(" ");}}
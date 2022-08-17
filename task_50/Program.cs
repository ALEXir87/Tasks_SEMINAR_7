// Задача №50: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

Console.WriteLine("Задача №50");
Console.Write("Введи номер позиции элемента строки: n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи номер позиции элемента столбца: m = ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [5,5];

FillArrayRandomNumbers(matrix);
if (n > matrix.GetLength(0) || m > matrix.GetLength(1)){
    Console.WriteLine("Такого элемента в массиве нет");}
if (n < 0 || m < 0){
    Console.WriteLine("Элемента с таким индексом нет");}
else{
    Console.WriteLine("Полученный массив: ");
    PrintArray(matrix);
    matrix[n, m] = matrix[n-1,m-1];
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца = {matrix[n, m]}");}

void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){        
            for (int j = 0; j < array.GetLength(1); j++){
                array [i,j] = new Random().Next(-10, 10);}}}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + "  ");}   
        Console.WriteLine("");}}
/**
*   Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*   m = 3, n = 4.
*   0,5 7 -2 -0,2
*   1 -3,3 8 -9,9
*   8 7,8 -7,1 9
*/

PrintDoubleArray(GetRandomDoubleArray(3, 4));

double[,] GetRandomDoubleArray(int m, int n) {
    Random rand = new Random();
    double[,] arr = new double[m, n];
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            int intPart = rand.Next(0, 9);
            double doublePart = Math.Round(rand.NextDouble(), 1);
            arr[i, j] = intPart + doublePart;     
        }
    }
    return arr;
}

void PrintDoubleArray(double[,] arr) {
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);

    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();       
    }
}
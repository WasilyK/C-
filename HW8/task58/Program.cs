/**
*   Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*   Например, даны 2 матрицы:
*   2 4 | 3 4
*   3 2 | 3 3
*   Результирующая матрица будет:
*   18 20
*   15 18
*/
using arrays;
ArrayHelper helper = new ArrayHelper();

int[,] matrix1 = helper.GetRandomArray(rows: 2, cols: 2, minValue: 1, maxValue: 9);
helper.PrintArray(matrix1);
Console.WriteLine("X");
int[,] matrix2 = helper.GetRandomArray(rows: 2, cols: 2, minValue: 1, maxValue: 9);
helper.PrintArray(matrix2);
Console.WriteLine("result:");
try {
    int[,] res = MultiplyMatrices(matrix1,matrix2);
    helper.PrintArray(res);
} catch (ArgumentException e) {
    Console.WriteLine(e.Message);
} catch (Exception e) {
    Console.WriteLine("Caught exception: " + e);
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2) {
    
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    if(cols1 != rows2) {
        throw new ArgumentException("matrices can't be multiplied");
    }
    
    int[,] res = new int[rows1, cols2];

    for(int row = 0; row < rows1; row++) {
        for(int col = 0; col < cols2; col++) { 
            for(int i = 0; i < cols1; i++) {
                res[row, col] += matrix1[row,i] * matrix2[i, col]; 
            }
            
        }
    }

    return res;
}
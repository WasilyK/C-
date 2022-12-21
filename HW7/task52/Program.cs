/**
*   Задайте двумерный массив из целых чисел. 
*   Найдите среднее арифметическое элементов в каждом столбце.
*   Например, задан массив:
*   1 4 7 2
*   5 9 2 3
*   8 4 2 4
*   Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
using mylib;
Utils utils = new Utils();

int[,] arr = utils.GetRandomIntArray();
utils.PrintIntArray(arr);

PrintDoubleArray(CalcColumnsAverage(arr));

double[] CalcColumnsAverage(int[,] arr) {
    int row = arr.GetUpperBound(0) + 1;
    int col = arr.GetUpperBound(1) + 1;

    double[] res = new double[col];

    for(int j = 0; j < col; j++) {
        double sum = 0.0;
        for(int i = 0; i < row; i++) {
            sum += arr[i, j];
        }
        res[j] = Math.Round(sum / row, 1);
    }

    return res;
}

void PrintDoubleArray(double[] arr) {
    int length = arr.Length;
    for(int i = 0; i < length; i++) {
        if(i == length - 1) {
            Console.Write(arr[i] + ".");
        } else {
            Console.Write(arr[i] + "; ");
        }
    }       
        
}
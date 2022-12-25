/**
*   Задайте прямоугольный двумерный массив. Напишите программу, 
*   которая будет находить строку с наименьшей суммой элементов.
*   Например, задан массив:
*   1 4 7 2
*   5 9 2 3
*   8 4 2 4
*   5 2 6 7
*   Программа считает сумму элементов в каждой строке и 
*   выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
using arrays;
ArrayHelper helper = new ArrayHelper();

int[,] arr = helper.GetRandomArray(rows: 4, cols: 4, minValue: 0, maxValue: 9);
helper.PrintArray(arr);
Console.WriteLine($"The number of row with smallest sum of elements: {getNumberRowWithMinSum(arr)}");

int getNumberRowWithMinSum(int[,] arr) {
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int minSum = 0;
    int res = 0;
    for(int i = 0; i < rows; i++) {
        int curSum = 0;
        for(int j = 0; j < cols; j++) {
            curSum += arr[i,j];
        }
        if(curSum < minSum || i == 0) {
            minSum = curSum;
            res = i;
        }
    }
    return res;
}
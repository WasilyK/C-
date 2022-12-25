/**
*   Задайте двумерный массив. Напишите программу, 
*   которая упорядочит по убыванию элементы каждой 
*   строки двумерного массива.
*   
*   Например, задан массив:
*   1 4 7 2
*   5 9 2 3
*   8 4 2 4
*   В итоге получается вот такой массив:
*   7 4 2 1
*   9 5 3 2
*   8 4 4 2
*/
using arrays;
ArrayHelper helper = new ArrayHelper();

int[,] arr = helper.GetRandomArray(rows: 3, cols: 4, minValue: -9, maxValue: 9);
Console.WriteLine("Source:");
helper.PrintArray(arr);
Sort(arr);
Console.WriteLine("After sort:");
helper.PrintArray(arr);

void Sort(int[,] arr) {
    if(arr == null) {
        return;
    }
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    for(int i = 0; i < rows; i++) {
        QuickSort(arr, i, 0, cols - 1);
    }
}
 
void QuickSort(int[,] arr, int row, int leftBorder, int rightBorder) {
    if(leftBorder == rightBorder) {
        return;
    }
    int leftMarker = leftBorder;
    int rightMarker = rightBorder;   
    int pivot = arr[row, (leftBorder + rightBorder) / 2];
    do {
        while(arr[row, rightMarker] < pivot) {
            rightMarker--;
        }
        while(arr[row, leftMarker] > pivot) {
            leftMarker++;
        }
        if(rightMarker > leftMarker) {
            Swap(arr, row, rightMarker, leftMarker);
        }
        leftMarker++;
        rightMarker--;

    } while (rightMarker > leftMarker);

    if(leftMarker < rightBorder) {
        QuickSort(arr, row, leftMarker, rightBorder);
    }
    if(leftBorder < rightMarker) {
        QuickSort(arr, row, leftBorder, rightMarker);
    }
}

void Swap(int[,] arr, int row, int i, int j) {
    int temp = arr[row, i];
    arr[row, i] = arr[row, j];
    arr[row, j] = temp;
}
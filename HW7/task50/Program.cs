/**
*   Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
*   и возвращает значение этого элемента или же указание, что такого элемента нет.
*   Например, задан массив:
*   1 4 7 2
*   5 9 2 3
*   8 4 2 4
*   17 -> такого числа в массиве нет
*/
using mylib;
Utils utils = new Utils();

int[,] arr = utils.GetRandomIntArray();
utils.PrintIntArray(arr);

int dim1 = utils.GetNumberFromUser("Enter a first dimension: ");
int dim2 = utils.GetNumberFromUser("Enter a second dimension: ");

try {
    Console.WriteLine(GetElement(arr, dim1, dim2));
} catch (ArgumentException e) {
    Console.WriteLine(e.Message);
} catch (Exception e) {
    Console.WriteLine("Exception caught: ", e);
}

int GetElement(int[,] arr, int dim1, int dim2) {
    int m = arr.GetUpperBound(0);
    int n = arr.GetUpperBound(1);
    if(dim1 < 0 || dim2 < 0 || dim1 > m || dim2 > n) {
        throw new ArgumentException("There is no element with such indexes");
    }
    return arr[dim1, dim2];
}
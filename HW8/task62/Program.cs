/**
*   Напишите программу, которая заполнит спирально массив 4 на 4.
*   Например, на выходе получается вот такой массив:
*   01 02 03 04
*   12 13 14 05
*   11 16 15 06
*   10 09 08 07
*/

try {
    PrintArray(SpiralFilling(size: 4));
} catch (Exception e) {
    Console.WriteLine("Caught exception: " + e.Message);
}

int[,] SpiralFilling(int size = 4) {
    
    if(size <= 0) {
        throw new ArgumentException("Array size is less or equal 0");
    }

    int[,] arr = new int[size,size];
    for(int i = 0; i < size; i++) {
        for(int j = 0; j < size; j++) {
            arr[i,j] = -1;
        }
    }

    int numb = 1;
    int row = 0;
    int col = 0;
    arr[row, col] = numb;
    while(numb < size * size) {        
        while(col + 1 != size && arr[row, col + 1] == -1) {
            arr[row, ++col] = ++numb;
        }
        while(row + 1 != size && arr[row + 1, col] == -1) {
            arr[++row, col] = ++numb;
        }
        while(col - 1 >= 0 && arr[row, col - 1] == -1) {
            arr[row, --col] = ++numb;
        }
        while(row - 1 >= 0 && arr[row - 1, col] == -1) {
            arr[--row, col] = ++numb;
        }
    }

    return arr;
}

void PrintArray(int[,] arr) {
    int size = arr.GetLength(0);
    int maxDigit = GetDigit(size * size);
    for(int i = 0; i < size; i++) {
        for(int j = 0; j < size; j++) {
            Console.Write($"{IntToString(arr[i,j], maxDigit)} ");
        }
        Console.WriteLine();
    }
}

string IntToString(int numb, int maxDigit) {
    int digit = GetDigit(numb);
    if(maxDigit < digit) {
        throw new ArgumentException("Too many digits in the number");
    }
    string res = "";
    int diff = maxDigit - digit;
    for(int i = 0; i < diff; i++) {
        res = res + "0";
    }
    return res + numb;
}

int GetDigit(int numb) {
    int digit = 0;
    for(int i = 1; numb / i >= 1; i *= 10, digit++);
    
    return digit;
}
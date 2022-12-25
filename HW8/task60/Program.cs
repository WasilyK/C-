/**
*   Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
*   Напишите программу, которая будет построчно выводить массив, 
*   добавляя индексы каждого элемента.
*   Массив размером 2 x 2 x 2
*   66(0,0,0) 25(0,1,0)
*   34(1,0,0) 41(1,1,0)
*   27(0,0,1) 90(0,1,1)
*   26(1,0,1) 55(1,1,1)
*/

try {
    PrintArray(GetArray(2,2,2));
} catch (Exception e) {
    Console.WriteLine("Caught exception: " + e.Message);
}

int[][][] GetArray(int size1, int size2, int size3) {

    if(size1 <= 0 || size2 <= 0 || size3 <= 0) {
        throw new ArgumentException("Incorrect array size");
    }
    
    Random rand = new Random();
    int[][][] arr = new int[size1][][];

    // Array contains the values of arr to check for duplication
    int[] values = new int[size1 * size2 * size3];
    // index of values
    int v = -1; 
    
    for(int i = 0; i < size1; i++) {
        arr[i] = new int[size2][];
        for(int j = 0; j < size2; j++) {
            arr[i][j] = new int[size3];
            for(int k = 0; k < size3; k++) {
                int value = rand.Next(10, 100);
                while(values.Contains(value)) {
                    value = rand.Next(10, 100);
                }
                values[++v] = value;
                arr[i][j][k] = value;
            }
        }
    }
    return arr;
}

void PrintArray(int[][][] arr) {
    int size1 = arr.Length;
    int size2 = arr[0].Length;
    int size3 = arr[1].Length;
    for(int i = 0; i < size1; i++) {
        for(int j = 0; j < size2; j++) {
            for(int k = 0; k < size3; k++) {
                Console.WriteLine($"{arr[i][j][k]}({i},{j},{k})");
            }
        }    
    }
}
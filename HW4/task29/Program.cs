/*  
*   Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*   1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
*   6, 1, 33 -> [6, 1, 33]
*/

printArray(getRandomArray(8));

int[] getRandomArray(int size) {
    int[] arr = new int[8];
    Random rand = new Random(); 

    for(int i = 0; i < size; i++) {
        arr[i] = rand.Next();
    }

    return arr;
}

void printArray(int[] arr) {
    int length = arr.Length;
    Console.Write("[");
    for(int i = 0; i < length; i++) {
        string endWith = i != length - 1 ? ", " : "";
        Console.Write($"{arr[i]}{endWith}");
    }
    Console.Write("]");
}
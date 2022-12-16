/**  
*   Задайте массив заполненный случайными положительными трёхзначными числами. 
*   Напишите программу, которая покажет количество чётных чисел в массиве.
*   [345, 897, 568, 234] -> 2
**/

int[] arr = GetRandomIntArray(10, 3);
if(arr == null) {
    Console.WriteLine("wrong input parameters");
}
Console.WriteLine(CountEvenNumbers(arr));

/**
*   Функция возвращает случайный массив
*   аргумент size - размер массива (не может быть 0 или меньше)
*   аргумент numberDigit - разряд чисел, если не указано, то ограничений нет (не может быть меньше 0)
**/ 
int[] GetRandomIntArray(int size, int numberDigit = 0) {
    
    if(numberDigit < 0 || size <= 0) {
        return null;
    }

    Random rand = new Random();
    int[] ints = new int[size];

    int minValue = GetMinValue(numberDigit);
    int maxValue = GetMaxValue(numberDigit);

    for(int i = 0; i < size; i++) {
        int numb = numberDigit == 0 ? 
            rand.Next() : rand.Next(minValue, maxValue + 1);
        numb *= rand.Next(0, 2) == 0 ? -1 : 1;
        ints[i] = numb;
    }

    return ints;
}

int GetMinValue(int digit) {
    
    if(digit <= 0) {
        return -1;
    }   

    int minValue = 1;

    for(int i = 1; i < digit; i++) {
        minValue *= 10;
    }

    return minValue;
}

int GetMaxValue(int digit) {

    if(digit <= 0) {
        return -1;
    }

    int minValue = GetMinValue(digit);

    return (minValue * 10) - 1;
}

int CountEvenNumbers(int[] arr) {
    
    int size = arr.Length;
    int count = 0;

    for(int i = 0; i < size; i++) {
        if(arr[i] % 2 == 0) {
            count++;
        }
    }

    return count;
}
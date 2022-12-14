/**
*   Задайте массив вещественных чисел. 
*   Найдите разницу между максимальным и минимальным элементов массива.
*   [3 7 22 2 78] -> 76
**/

double[] arr = GetRandomDoubleArray(size: 10, numberDigit: 3, dec: 2);
if(arr == null) {
    Console.WriteLine("wrong input parameters");
}
Console.WriteLine(findMax(arr) - Math.Abs(findMin(arr)));

/**
*   Функция возвращает случайный массив
*   аргумент size - размер массива (не может быть 0 или меньше)
*   аргумент numberDigit - разряд чисел, если не указано, то ограничений нет (не может быть меньше 0)
*   аргумент dec - количество цифр после запятой, если не указано, то ограничений нет (не может быть меньше 0)
**/  
double[] GetRandomDoubleArray(int size, int numberDigit = 0, int dec = 0) {

    if(numberDigit < 0 || size <= 0 || dec < 0) {
        return null;
    }

    int[] ints = GetRandomIntArray(size, numberDigit);
    double[] doubles = new double[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++) {
        doubles[i] = ints[i] + rand.NextDouble();
        if(dec > 0) {
            doubles[i] = Math.Round(doubles[i], dec);
        }
    }

    return doubles;
}

double findMax(double[] arr) {
    double max = arr[0];
    int length = arr.Length;

    for(int i = 1; i < length; i++) {
        if(arr[i] > max) {
            max = arr[i];
        }
    }

    return max;
}

double findMin(double[] arr) {
    double min = arr[0];
    int length = arr.Length;

    for(int i = 1; i < length; i++) {
        if(arr[i] < min) {
            min = arr[i];
        }
    }

    return min;
}

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
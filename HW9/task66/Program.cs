/**
*   Задайте значения M и N. Напишите программу, 
*   которая найдёт сумму натуральных элементов в промежутке от M до N.
*   M = 1; N = 15 -> 120
*   M = 4; N = 8. -> 30
*/
using user_interaction;
Input input = new Input();

int m = input.GetNumberFromUser("Enter a first number: ");
int n = input.GetNumberFromUser("Enter a second number: ");

Console.WriteLine(Sum(GetMax(m, n), GetMin(m, n)));

int Sum(int max, int min) {
    if(max <= 0 || min == max - 1) {
        return 0;
    }
    return (max - 1) + Sum(--max, min);
}

int GetMax(int m, int n) {
    return m > n ? m : n;
}

int GetMin(int m, int n) {
    return m > n ? n : m;
}
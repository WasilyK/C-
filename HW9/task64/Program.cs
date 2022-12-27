/**
*   Задайте значение N. Напишите программу, которая выведет все 
*   натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*   N = 5 -> "5, 4, 3, 2, 1"
*   N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
using user_interaction;
Input input = new Input();

int numb = input.GetNaturalNumberFromUser();

Console.Write("\"");
PrintNumber(numb);

void PrintNumber(int numb) {
    if(numb - 1 == 0) {
        Console.Write(numb + "\"");
        return;
    }
    Console.Write(numb + ", ");
    PrintNumber(numb - 1);
}


/* Напишите программу, которая принимает на вход цифру, 
    обозначающую день недели, и проверяет, является ли этот день выходным. */

Console.WriteLine(isWeekend(getDayNumberFromUser()) ? "Да" : "Нет");

int getDayNumberFromUser() {
    int day = -1;
    do {
        Console.Write("Пожалуйста, введите число дня недели от 1 до 7 и нажмите \"Enter\": ");
        day = int.Parse(Console.ReadLine());
    } while (day < 1 || day > 7);
    return day; 
}

bool isWeekend(int day) {
    return day == 7 || day == 6;
}



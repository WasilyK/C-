/* Напишите программу, которая принимает на вход трёхзначное число 
    и на выходе показывает вторую цифру этого числа. */

Console.WriteLine("Show second digit");

int numb = getNumberFromUser();
Console.WriteLine(getSecondDigit(numb));

int getNumberFromUser() {
    Console.Write("Пожалуйста, введите трехзначное число и нажмите \"Enter\": ");
    int number = int.Parse(Console.ReadLine());
    for( ; number <= 99 || number > 999; ) {
        Console.Write("Are you kidding me? Please enter a three-digit number and press \"Enter\": ");
        number = int.Parse(Console.ReadLine());
    }
    return number; 
}

int getSecondDigit(int number) {
    number = number / 10;
    return number % 10;
}
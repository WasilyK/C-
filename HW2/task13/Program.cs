/* Напишите программу, которая выводит третью цифру заданного числа 
    или сообщает, что третьей цифры нет.*/

Console.WriteLine("Show third digit or tell me it's not there");

Console.Write("Пожалуйста, введите число и нажмите \"Enter\": ");
int numb = int.Parse(Console.ReadLine());

numb = getThirdDigit(numb);
Console.WriteLine( numb == -1 ? "Третьей цифры нет" : numb);

int getThirdDigit(int number) {
    if(number <= 99) {
        return -1;
    } 
    while(number > 999) {
        number /= 10;
    }

    return number % 10;
}
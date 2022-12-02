/* Напишите программу, которая на вход принимает число и выдаёт, 
    является ли число чётным (делится ли оно на два без остатка). */

Console.WriteLine("Is the number even?");

Console.Write("Пожалуйста, введите число и нажмите \"Enter\": ");
int number = int.Parse(Console.ReadLine());

while(number > 2) {
    number -= 2;
}

if(number == 1) {
    Console.Write("Нечетное");
} else {
    Console.Write("Четное");
}

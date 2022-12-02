/* Напишите программу, которая на вход принимает число (N), 
    а на выходе показывает все чётные числа от 1 до N. */

Console.WriteLine("Show even numbers");

Console.Write("Пожалуйста, введите число и нажмите \"Enter\": ");
int number = int.Parse(Console.ReadLine());

for(int i = 1; i <= number; i++) {
    if(i % 2 == 0) {
        Console.Write(" " + i);
    }
}
/* Напишите программу, которая на вход принимает два числа и выдаёт, 
    какое число большее, а какое меньшее. */

Console.WriteLine("Очень крутая программа для сравнения двух целых чисел!");

Console.Write("Пожалуйста, введите первое число и нажмите \"Enter\": ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Пожалуйста, введите второе число и нажмите \"Enter\": ");
int n2 = int.Parse(Console.ReadLine());

if(n1 > n2) {
    Console.WriteLine("Первое число больше.");
} else if (n1 < n2) {
    Console.WriteLine("Второе число больше");
} else {
    Console.WriteLine("Числа равны");
}

/* Напишите программу, которая принимает на вход 
    три числа и выдаёт максимальное из этих чисел. */
    
Console.WriteLine("Find MAX");

int[] numbs = new int[3];

Console.Write("Пожалуйста, введите первое число и нажмите \"Enter\": ");
numbs[0] = int.Parse(Console.ReadLine());

Console.Write("Пожалуйста, введите второе число и нажмите \"Enter\": ");
numbs[1] = int.Parse(Console.ReadLine());

Console.Write("Пожалуйста, введите третье число и нажмите \"Enter\": ");
numbs[2] = int.Parse(Console.ReadLine());

int max = numbs[0];

for(int i = 0; i < numbs.Length; i++) {
    if(numbs[i] > max) {
        max = numbs[i];
    }
}

Console.WriteLine("Максимальное число: " + max);

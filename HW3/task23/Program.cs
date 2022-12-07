/* Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу кубов чисел от 1 до N. */

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

printTable(printCube, number);

void printTable(Action<int> action, int numb) {
    Console.Write($"{numb} -> ");
    for(int i = 1; i <= numb; i++) {
        printCube(i);
    }
}

void printCube(int x) => Console.Write($"{Math.Pow(x, 3)} ");  

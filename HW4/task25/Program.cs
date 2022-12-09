/*  
*   Напишите цикл, который принимает на вход два числа (A и B) 
*   и возводит число A в натуральную степень B.
*   3, 5 -> 243 (3⁵)
*   2, 4 -> 16 
*/

Console.Write("Enter a number: ");
int numb = int.Parse(Console.ReadLine());
Console.Write("Enter a power: ");
int pow = int.Parse(Console.ReadLine());

Console.WriteLine(powerCycle(numb, pow));

int powerCycle(int numb, int pow) {
    int res = 1;
    for(int i  = 0; i < pow; i++) {
        res *= numb;
    }
    return res;
}
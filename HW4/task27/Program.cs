/* 
*   Напишите программу, которая принимает на вход число 
*   и выдаёт сумму цифр в числе.
*   452 -> 11
*   82 -> 10
*   9012 -> 12
*/

Console.Write("Enter a number: ");
int numb = int.Parse(Console.ReadLine());

Console.WriteLine(sumDigit(numb));

int sumDigit(int numb) {
    int res = 0;
    int rem = 0;
    do {
        rem = numb % 10;
        res += rem;

    } while( (numb /= 10) >= 1);

    return res;
}

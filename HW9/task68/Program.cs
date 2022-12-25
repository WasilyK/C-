/**
*   Напишите программу вычисления функции Аккермана с помощью рекурсии. 
*   Даны два неотрицательных числа m и n.
*   m = 2, n = 3 -> A(m,n) = 9
*   m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine(AkkFunc(3,2));

int AkkFunc(int m, int n) {
    if(m < 0 || n < 0) {
        throw new ArgumentException("negative number");
    }
    if(m == 0) {
        return n + 1;
    }
    if(n == 0) {
        return AkkFunc(m - 1, 1);
    }
    return AkkFunc(m - 1, AkkFunc(m, n - 1));
}
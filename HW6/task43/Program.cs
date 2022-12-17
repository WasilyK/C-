/**
*   Напишите программу, которая найдёт точку пересечения двух прямых, 
*   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
*   значения b1, k1, b2 и k2 задаются пользователем.
*   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
using mylib;
Utils utils = new Utils();

utils.ShowMessage("I'll find x & y\n");
int k1 = GetNumberFromUser("Enter k1: ", utils);
int b1 = GetNumberFromUser("Enter b1: ", utils);
int k2 = GetNumberFromUser("Enter k2: ", utils);
int b2 = GetNumberFromUser("Enter b2: ", utils);

PrintXY(k1, b1, k2, b2);

int GetNumberFromUser(string msg, Utils utils) {
    string input = "";
    do {
        input = utils.GetUserInput(msg);

    } while(!utils.IsValidNumber(input));

    return utils.StringToInt(input);
}

void PrintXY(int k1, int b1, int k2, int b2) {
    double x = (double) (b2 - b1)/(k1 - k2);
    double y = (double) (b1 * k2 - b2 * k1) / (k2 - k1);
    Console.WriteLine($"({x},{y})");
} 
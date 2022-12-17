/**
*   Пользователь вводит с клавиатуры M чисел. 
*   Посчитайте, сколько чисел больше 0 ввёл пользователь.
*   0, 7, 8, -2, -2 -> 2
*   1, -7, 567, 89, 223-> 3
*/
using mylib;

Utils utils = new Utils();

utils.ShowMessage("I'll count how many positive numbers you have entered.\n");

string msg = "Please, enter the number or "
                + "enter \"q\" to exit and press \"Enter\": ";

int number = CountPositiveNumbers(msg, utils);

Console.WriteLine($"You've entered {number} positive numbers.");

int CountPositiveNumbers(string msg, Utils utils) {
    int count = 0;
    while(true) {
        string inp = utils.GetUserInput(msg);
        if(inp.Equals("q")) {
            break;
        } else if(utils.IsValidNumber(inp)) {
            if(utils.StringToInt(inp) > 0) {
                count++;
            }
        } else {
            continue;
        }
    }
    return count;
}
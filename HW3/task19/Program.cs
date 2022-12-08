/*  Напишите программу, которая принимает на вход пятизначное число 
*   и проверяет, является ли оно палиндромом. 
*/

Console.WriteLine("Is a number palindrome?");
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());


/*
*   С Вашего позволения, решил усложнить задачу на любое целое число.
*/
Console.WriteLine(isNumberPalindrome(number) ? "Yes" : "No");

/* 
*   Функция возвращает разрядность целого числа
*/ 
int getDigit(int numb) {
    int digit = 0;
    for(int i = 1; numb / i >= 1; i *= 10, digit++);
    
    return digit;
}

/* 
*   Функция возвращает true, если число палиндром
*   иначе false
*/ 
Boolean isNumberPalindrome(int numb) {   

    numb = Math.Abs(numb); 

    int digit = getDigit(numb);

    if(digit == 0 || digit == 1) {
        // Если число 0 либо одноразрядное, то это уже палиндром 
        return true;
    }

    if(digit == 2) {
        // Отдельно рассматриваем двухразрядные числа
        return (numb / 10) == (numb % 10);
    }

    for(int right = 10, left = (int) Math.Pow(10, digit - 1);
        right < left;
        right *= 10, left /= 10 ) {

            int rightNumber = numb % right;
            int rightDigit = getDigit(rightNumber);
            rightNumber = rightNumber / (int) Math.Pow(10, rightDigit - 1);

            int leftNumber = (numb / left) % 10;

            if(rightNumber != leftNumber) {
                // Если какие либо смежные разряды не равны, значит не палиндром
                return false;
            }

        }

    return true;
}
/* Напишите программу, которая выводит на экран числа от 1 до 100. 
При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», 
а вместо чисел, кратных пяти — слово «Buzz». 
Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz» */

var printFizz = (int i) => { return i % 3 == 0 ? "Fizz" : ""; };
var printBuzz = (int i) => { return i % 5 == 0 ? "Buzz" : ""; };
var printNumb = (int i, string f, string b) => { return f != "" || b != "" ? "" : $"{i}"; };

for(int i = 1; i < 101; i++) {
    String f = "";
    String b = "";
    Console.Write($"{f = printFizz(i)}{b = printBuzz(i)}{printNumb(i,f,b)}, ");
}

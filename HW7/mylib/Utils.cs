namespace mylib;
using System.Text.RegularExpressions;

public class Utils {

    public string GetUserInput(string msg) {
        Console.Write(msg);
        return Console.ReadLine();
    } 

    public bool IsValidNumber(string strNumb) {
        string pattern = @"^-?\d+$";
        return Regex.IsMatch(strNumb, pattern);
    }

    public int StringToInt(string strNumb) {
        return int.Parse(strNumb);
    }

    public int GetNumberFromUser(string msg) {
        string input = "";
        do {
            input = GetUserInput(msg);

        } while(!IsValidNumber(input));

        return StringToInt(input);
    }

    public void PrintIntArray(int[,] arr) {
        int m = arr.GetUpperBound(0) + 1;
        int n = arr.GetUpperBound(1) + 1;

        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();       
        }
    }

    public int[,] GetRandomIntArray() {
        Random rand = new Random();
        int m = rand.Next(1,9);
        int n = rand.Next(1,9);
        int[,] arr = new int[m, n];
        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                int numb = rand.Next(0, 9);
                arr[i, j] = numb;     
            }
        }
        return arr;
    }
}

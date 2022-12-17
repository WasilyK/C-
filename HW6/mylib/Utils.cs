namespace mylib;
using System.Text.RegularExpressions;

public class Utils {

    public void ShowMessage(string msg) {
        Console.WriteLine(msg);
    }

    public string GetUserInput(string msg) {
        Console.Write(msg);
        return Console.ReadLine();
    } 

    public bool IsValidNumber(string strNumb) {
        string pattern = @"^\d+$";
        return Regex.IsMatch(strNumb, pattern);
    }

    public int StringToInt(string strNumb) {
        return int.Parse(strNumb);
    }
}

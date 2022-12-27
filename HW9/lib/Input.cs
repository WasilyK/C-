namespace user_interaction;
using System.Text.RegularExpressions;

public class Input {
    public string GetUserInput(string msg) {
        Console.Write(msg);
        return Console.ReadLine();
    } 

    public int GetNumberFromUser(string msg) {
        string input = "";
        int number = 0;
        do {
            input = GetUserInput(msg);

        } while(!int.TryParse(input, out number));

        return number;
    }

    public int GetNaturalNumberFromUser() {
        int numb = 0;
        do {
            numb = GetNumberFromUser("Enter a natural number: ");

        } while(!isNatural(numb));
        
        return numb;
    }

    public bool isNatural(int number) {
        return number > 0;
    }
}

using System;

public class Program
{
    public static void Main()
    {
        string? texte = "";
        while (texte == "") {
            Console.WriteLine("Veuillez rentrer du text : ");
            texte = Console.ReadLine();
        }
        if (texte is not null) {
            Console.Write(ConvertToUpper(texte));
        }
    }

    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}
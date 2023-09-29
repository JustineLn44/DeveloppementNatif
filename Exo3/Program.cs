using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Entrez un nombre: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number%2 == 0)
            {
                Console.WriteLine("Votre nombre est pair");
            }
            else
            {
                Console.WriteLine("Votre nombre est impair");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}
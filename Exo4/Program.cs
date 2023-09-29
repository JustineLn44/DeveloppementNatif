using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static List<char> alphabet = new List<char>
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    public static void Main()
    {
        AlgoTest(MyNameIs);
        Console.ReadLine();
    }

    public static string MyNameIs(string name)
    {
        string value = "";
        name = name.ToLower();
        char[] ch = new char[name.Length];

        for (int i = 0; i < name.Length; i++)
        {
            ch[i] = name[i];
            int index = 0;
            foreach (char c in alphabet)
            {
                if (ch[i] == c)
                {
                    value += index;
                }
                index++;
            }
        }
        
        Console.WriteLine(value);
        return value.ToString();

        // myNameIs("Ahmed") should return  '071243'
        // myNameIs("Dorlean") return 31417114013
        // myNameIs("a") return  0
        // myNameIs("Sandrine") return 180133178134

    }

    public static void AlgoTest(Func<string, string> func)
    {
        if (func("Sandrine") == "180133178134")
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
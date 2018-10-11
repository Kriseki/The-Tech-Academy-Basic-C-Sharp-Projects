using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = { "Bear", "Fox", "Wolf", "Cat", "Dog" };
        Console.WriteLine("Choose an index between 0 and 4.");
        string Guess = Console.ReadLine();
        int intGuess = Convert.ToInt32(Guess);
        Console.WriteLine("You chose the index " + Guess + " which is " + stringArray[intGuess] + ".");
        Console.ReadLine();

        int[] intArray = { 3, 5, 22, 55, 60 };
        Console.WriteLine("Choose an index between 0 and 4.");
        string secGuess = Console.ReadLine();
        int secIntGuess = Convert.ToInt32(secGuess);
        Console.WriteLine("You chose the index " + secGuess + " which is " + intArray[secIntGuess] + ".");
        Console.ReadLine();

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Add(55);
        intList.Add(60);
        intList.Add(100);
        Console.WriteLine("Choose an idex between 0 and 4.");
        string thirdGuess = Console.ReadLine();
        int thirdIntGuess = Convert.ToInt32(thirdGuess);
        Console.WriteLine("You chose the index " + thirdGuess + " which is " + intList[thirdIntGuess]);
        Console.ReadLine();
    }
}

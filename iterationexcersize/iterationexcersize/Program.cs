using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //NUMBER 1
        string[] names = new string[3];
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Enter name");
            names[i] = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine();

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine();

        //NUMBER 2
        //for (int i = 0; i - 1 < i++; i++)
        //{
        //    Console.WriteLine("Oh no!");
        //}

        Console.ReadLine();

        //NUMBER 3
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("That's better!");
        }

        Console.ReadLine();

        //NUMBER 4
        int[] speeds = { 44, 36, 29, 33, 48, 55, 40, 36 };

        for (int i = 0; i < speeds.Length; i++)
        {
            if (speeds[i] > 40)
            {
                Console.WriteLine("Speeds exceeding the 40mph limit: " + speeds[i]);
            }
        }
        Console.ReadLine();

        //NUMBER 5
        int[] scores = { 55, 90, 92, 88, 65, 78, 80, 44, 53, 62, 99, 85 };
        foreach (int score in scores)
            if (score <= 65)
            {
                Console.WriteLine("Not passing score: " + score);
            }
        Console.ReadLine();

        //NUMBER 6
        List<string> animals = new List<string>() { "dog", "cat", "bird", "rabbit", "snake", "fish" };

        Console.WriteLine("Please select an animal from: dog, cat, bird, rabbit, snake, or fish");
        string selectedAnimal = Console.ReadLine();

        foreach (string animal in animals)
        {
            if (selectedAnimal == animal)
            {
                Console.WriteLine();
                Console.WriteLine("You have selected " + selectedAnimal + " which is in index " + animals.IndexOf(selectedAnimal) + ".");
                Console.ReadLine();
            }
        }

        //NUMBER 7
        List<string> animals2 = new List<string>() { "dog", "cat", "bird", "rabbit", "snake", "fish" };

        Console.WriteLine("Please select an animal from: dog, cat, bird, rabbit, snake, or fish");
        string selectedAnimal2 = Console.ReadLine();

        foreach (string animal2 in animals2)
        {
            if (selectedAnimal2 == animal2)
            {
                Console.WriteLine();
                Console.WriteLine("You have selected " + selectedAnimal2 + " which is in index " + animals2.IndexOf(selectedAnimal2) + ".");
                Console.WriteLine();
                break;
            }

            else if (!animals2.Contains(selectedAnimal2))
            {
                Console.WriteLine();
                Console.WriteLine(selectedAnimal2 + " is not a valid choice.");
                Console.WriteLine();
                break;
            }
        }

        //NUMBER 8
        List<string> animals3 = new List<string>() { "dog", "cat", "bird", "rabbit", "snake", "fish" };

        Console.WriteLine("Please select an animal from: dog, cat, bird, rabbit, snake, or fish");
        string selectedAnimal3 = Console.ReadLine();

        foreach (string animal3 in animals3)
        {
            if (selectedAnimal3 == animal3)
            {
                Console.WriteLine();
                Console.WriteLine("You have selected " + selectedAnimal3 + " which is in index " + animals3.IndexOf(selectedAnimal3) + ".");
                Console.WriteLine();
                break;
            }

            else if (!animals3.Contains(selectedAnimal3))
            {
                Console.WriteLine();
                Console.WriteLine(selectedAnimal3 + " is not a valid choice.");
                Console.WriteLine();
                break;
            }
        }

        //NUMBER 9
        List<string> letters = new List<string>(new string[] { "a", "b", "c", "b", "a", "a", "b", "c" });
        Console.WriteLine("Select a grade from the list: a, b, c, b, a, a, b, c");
        string grade = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("You have selected " + grade + " which is in index(es)");

        for (int k = 0; k < letters.Count; k++)
            if (letters[k] == grade)
                Console.WriteLine(k);
        Console.ReadLine();

        //NUMBER 10
        List<string> letters2 = new List<string>(new string[] { "a", "b", "c", "b", "a", "a", "b", "c" });
        Console.WriteLine("Select a grade from the list: a, b, c, b, a, a, b, c");
        string grade2 = Console.ReadLine();
        Console.WriteLine();


        for (int c = 0; c < letters2.Count; c++)
            if (letters2[c] == grade2)
                Console.WriteLine("Index: " + c);


        if (!letters2.Contains(grade2))
        {
            Console.WriteLine(grade2 + " is not a valid choice.");
        }

        Console.ReadLine();

        //NUMBER 11
        List<string> pets = new List<string>(new string[] { "cat", "dog", "tiger", "elephant", "cat", "monkey" });
        List<string> pets2 = new List<string>();
        foreach (string pet in pets)
        {
            
            Console.WriteLine(pet);

            if (pets2.Contains(pet))
            {
                Console.WriteLine("On list twice");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("On the list once");
                Console.WriteLine();
                pets2.Add(pet);
            }

        }

        Console.ReadLine();
    }

}


using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int age;
        string rating;

        Console.WriteLine("Please enter age");
        Console.WriteLine("");

        Console.Write("age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (age >= 17)
        {
            rating = "You can see R movies.";
        }
        else if (age >= 13)
        {
            rating = "You can see PG movies.";
        }
        else if (age >= 5)
        {
            rating = "You can see P movies.";
        }
        else
        {
            rating = "You can't see any movies.";
        }

        Console.WriteLine(rating);

        Console.WriteLine("\nDone.");
    }
}
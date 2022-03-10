// See https://aka.ms/new-console-template for more information

namespace Day08Demo;

public enum Gender
{
    NotProvided,
    Male,
    Female
}

public class EnumDemo
{    
    public static void Test()
    {
        Gender gender = Gender.NotProvided;

        Console.WriteLine($"1. Gender = {gender}");
        
        Console.WriteLine("Enter your gender");
        var genderText = Console.ReadLine();    // male/female

        gender = (Gender)Enum.Parse(typeof(Gender), genderText);

        Console.WriteLine($"2. Gender = {gender}");        
    }

    public static void TestParse()
    {
        // Convert string to enum
        // similar to double parse or int parse
        string s = "100.50";
        double d = double.Parse(s);

        string s2 = "Female";

        Gender g = (Gender)Enum.Parse(typeof(Gender), s2);  // Old C# syntax, not to be used now
        Gender g2 = Enum.Parse<Gender>(s2);                 // Simple Syntax using Generics

        Console.WriteLine($"g = {g} & g2 = {g2}");
    }
}
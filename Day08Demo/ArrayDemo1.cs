// See https://aka.ms/new-console-template for more information
//ArrayDemo1.TestArray1();
//ArrayDemo1.TestArray2();

// 1. Global namespace
// 2. file scoped namespace

namespace Day08Demo;

class ArrayDemo1
{
    public static void TestArray1()
    {
        string[] cars = { "Volvo", "BMW", "Ford" };
        int[] ages1 = new int[4] { 1, 2, 3, 4 };
        int[] ages2 = new int[] { 1, 2, 3, 4 };
        int[] ages3 = { 1, 2, 3, 4 };

        int[] ages4 = new int[10];

        ages4[0] = 10;
        ages4[1] = 20;

        Console.WriteLine(ages4[0]);

        for (int i = cars.Length - 1; i >= 0; i--)
        {
            var car = cars[i];
            Console.WriteLine(car);
            cars[i] = "xyz";
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        Array.Sort(ages3);
        Array.Reverse(ages4);
    }

    public static void TestArray2()
    {
        int[] salaries = { 7000, 9000, 25000, 2000 };
        Array.ForEach(salaries, n => Console.Write($"{n},"));

        Console.WriteLine("\n---------------------");
        foreach (var n in salaries)
        {
            Console.Write($"{n},");
        }

        Array.Sort(salaries);
        Console.WriteLine("\n---------------------");
        Array.ForEach(salaries, n => Console.Write($"{n},"));
        Console.WriteLine("\n---------------------");

        // 2000,7000,9000,25000,
        var result = Array.BinarySearch(salaries, 2500);
        if (result >= 0)
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not Found");

        Console.WriteLine($"Binary Search result = {result}");
    }

    public static void TestArray3()
    {
        int[] sizes = { 5, 1, 8, 9, 100, 250 };

        var maxNum = sizes.Max();
    }
}


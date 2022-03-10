using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Demo;

internal class StructDemo
{
    public static void Test()
    {
        var line = new Line
        {
            p1 = new Point { x = 10, y = 10 },
            p2 = new Point { x = 30, y = 20 },
        };

        //var p1 = new Point { x = 10, y = 10 };
        //var p2 = new Point { x = 30, y = 20 };
        //var line = new Line { p1 = p1, p2 = p2 };

        line.Show();
    }
}

public struct Point
{
    public int x;
    public int y;

    public void Show()
    {
        Console.WriteLine($"x:{x}, y:{y}");
    }
}

public struct Line
{
    public Point p1;
    public Point p2;

    public void Show()
    {
        p1.Show();
        p2.Show();
    }
}

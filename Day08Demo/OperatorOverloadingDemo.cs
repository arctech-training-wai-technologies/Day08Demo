using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Demo
{
    class Rectangle
    {
        private int _x;
        private int _y;
        private int _length;
        private int _width;


        public static void Something()
        {
            Console.WriteLine("Something");
        }

        public Rectangle(int x, int y, int length, int width)
        {
            _x = x;
            _y = y;
            _length = length;
            _width = width;
        }

        public void Show()
        {
            var topDownLine = new string('-', _width);
            var sideLines = $"|{new string(' ', +_width - 2)}|";

            Console.SetCursorPosition(_x, _y);
            Console.Write(topDownLine);

            for (int row = 1; row < _length - 1; row++)
            {
                Console.SetCursorPosition(_x, _y + row);
                Console.Write(sideLines);
            }

            Console.SetCursorPosition(_x, _y + _length - 1);
            Console.Write(topDownLine);
        }

        public Rectangle Merge(Rectangle rectange)
        {
            var rectangleFinal = new Rectangle(
                Math.Min(_x, rectange._x),
                Math.Min(_y, rectange._y),
                Math.Max(_width, rectange._width),
                Math.Max(_length, rectange._length));

            return rectangleFinal;
        }

        public static Rectangle operator+(Rectangle rectangle1, Rectangle rectangle2)
        {
            var rectangleFinal = new Rectangle(
                Math.Min(rectangle1._x, rectangle2._x),
                Math.Min(rectangle1._y, rectangle2._y),
                Math.Max(rectangle1._width, rectangle2._width),
                Math.Max(rectangle1._length, rectangle2._length));

            return rectangleFinal;
        }
    }

    internal class OperatorOverloadingDemo
    {
        public static void Test()
        {
            int a = 10 + 20;

            string s = string.Concat("First ", " Last");
            string s2 = "First " + " Last";

            Rectangle rectangle1 = new Rectangle(10, 0, 5, 10);
            Rectangle rectangle2 = new Rectangle(20, 0, 10, 20);

            rectangle1.Show();
            rectangle2.Show();

            Console.ReadKey();
            Console.Clear();

            Rectangle rectangle4 = rectangle1.Merge(rectangle2);
            rectangle4.Show();

            Rectangle rectangle5 = rectangle1 + rectangle2;
            rectangle5.Show();            

            Rectangle r = new Rectangle(10, 0, 5, 10);
            r.Show();                        
        }
    }
}

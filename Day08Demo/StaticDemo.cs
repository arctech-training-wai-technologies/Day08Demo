using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Demo
{
    public class Human
    {
        public DateTime DateOfBirth;
        public double Height;

        public static int averageLifeSpan;
        public static long totalPopulation;

        public static void IncreaseLifeSpan()
        {
            averageLifeSpan++;
        }

        public void Show()
        {
            Console.WriteLine($"DateOfBirth={DateOfBirth}, Height={Height}, avg life span={averageLifeSpan}, totalPopulation={totalPopulation}");
        }
    }


    internal class StaticDemo
    {
        public static void Test()
        {
            Human.averageLifeSpan = 75;
            Human.totalPopulation = 5673838383;
            Human.IncreaseLifeSpan();

            //Human human = new Human();
            //human.Height = 156;
            //human.DateOfBirth = new DateTime(1979, 8, 17);
            //human.Show();

            //Human human2 = new Human();
            //human2.Height = 176;
            //human2.DateOfBirth = new DateTime(1992, 2, 7);
            //human2.Show();
        }
    }
}

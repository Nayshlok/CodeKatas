using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(SumOfStrings.sumStrings("123", "12"));
            //Console.WriteLine(SumOfStrings.sumStrings("12", "123"));
            Console.WriteLine(SumOfStrings.sumStrings("1", "99"));
            Console.WriteLine(SumOfStrings.sumStrings("00091", "030"));
            //int[][] array =
            //{
            //    new []{1, 2, 3},
            //    new []{4, 5, 6},
            //    new []{7, 8, 9}
            //};

            //int[][] array =
            //{
            //    new []{1, 2, 3, 4, 5},
            //    new []{6, 7, 8, 9, 10},
            //    new []{11, 12, 13, 14, 15},
            //    new []{16, 17, 18, 19, 20},
            //    new []{21, 22, 23, 24, 25}
            //};

            int[][] array =
            {
                new []{1},
            };
            var sorted = SnailSort.Snail(array);
            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}

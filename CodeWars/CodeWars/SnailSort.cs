using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class SnailSort
    {
        public static int[] Snail(int[][] array)
        {
            int x = 0;
            int y = 0;
            int left = 0;
            int top = 0;
            int right = array[0].Length - 1;
            int bottom = array.Length - 1;
            int step = 0;
            bool allSame = false;
            bool isEven = array.Length % 2 == 0;
            int[] resultarray = new int[array[0].Length * array.Length];
            if(array[0].Length == 0)
            {
                return resultarray;
            }
            while (!allSame)
            {
                int currentNumber = array[y][x];
                resultarray[step] = currentNumber;
                step++;

                if (x < right && y <= top)
                {
                    x++;
                }
                else if(x >= right && y < bottom)
                {
                    y++;
                }
                else if(x > left && y >= bottom)
                {
                    x--;
                }
                else if(x <= left && y > top)
                {
                    y--;
                }

                if (right == left && top == bottom)
                {
                    allSame = true;
                    if (resultarray.Length > 2)
                    { 
                        resultarray[step] = array[y][x];
                        step++;
                        if (!isEven)
                        {
                            x++;
                            resultarray[step] = array[y][x];
                        }
                        else
                        {
                            x--;
                            resultarray[step] = array[y][x];
                        }
                    }
                }

                if (x == right && y == top)
                {
                    right--;
                    if (top < bottom)
                    {
                        top++;
                    }
                }
                if (x == left && y == bottom)
                {
                    if (left < right)
                    {
                        left++;
                    }
                    bottom--;
                }
            }

            return resultarray;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    /*
     Given the string representations of two integers, return the string representation of the sum of those integers.

    For example:

    sumStrings('1','2') // => '3'

    A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
    */

    class SumOfStrings
    {
        public static string sumStrings(string a, string b)
        {
            a = a.TrimStart('0');
            b = b.TrimStart('0');
            Stack<string> finalResult = new Stack<string>();
            int i = a.Length - 1;
            int j = b.Length - 1;
            bool carry = false;
            while (i >= 0 || j >= 0)
            {
                if (i >= 0 && j >= 0)
                {
                    int aInt = int.Parse(a[i].ToString());
                    int bInt = int.Parse(b[j].ToString());
                    int sum = aInt + bInt;
                    if (carry)
                    {
                        sum += 1;
                        carry = false;
                    }
                    if (sum >= 10)
                    {
                        carry = true;
                    }
                    int moddedSum = sum % 10;
                    finalResult.Push(moddedSum.ToString());
                }
                else if (i >= 0)
                {
                    if (carry)
                    {
                        int aInt = int.Parse(a[i].ToString());
                        aInt += 1;
                        if (aInt < 10)
                        {
                            carry = false;
                        }
                        finalResult.Push((aInt % 10).ToString());
                    }
                    else
                    {
                        finalResult.Push(a[i].ToString());
                    }
                }
                else if (j >= 0)
                {
                    if (carry)
                    {
                        int bInt = int.Parse(b[j].ToString());
                        bInt += 1;
                        if (bInt < 10)
                        {
                            carry = false;
                        }
                        finalResult.Push((bInt % 10).ToString());
                    }
                    else
                    {
                        finalResult.Push(b[j].ToString());
                    }
                }
                i--;
                j--;
            }
            if (carry)
            {
                finalResult.Push("1");
            }
            return string.Join("", finalResult);
        }

    }
}

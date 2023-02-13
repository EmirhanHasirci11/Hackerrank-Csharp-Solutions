using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

   
    /// <summary>
    /// Using XOR gate to find unique number in an array
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int lonelyinteger(List<int> a)
    {
        int result = 0;
        foreach(int i in a)
        {
            result ^= i;
        }
        return result;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result);
       
    }
}

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

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {


        string hour = s.Substring(0, 2);
        if (s.Substring(s.Length - 2) == "PM")
        {
            s = s.Substring(0, s.Length - 2);
            s = s.Substring(2);
            switch (hour)
            {

                case "01":
                    s = "13" + s;
                    break;
                case "02":
                    s = "14" + s;
                    break;
                case "03":
                    s = "15" + s;
                    break;
                case "04":
                    s = "16" + s;
                    break;
                case "05":
                    s = "15" + s;
                    break;
                case "06":
                    s = "18" + s;
                    break;
                case "07":
                    s = "19" + s;
                    break;
                case "08":
                    s = "20" + s;
                    break;
                case "09":
                    s = "21" + s;
                    break;
                case "10":
                    s = "22" + s;
                    break;
                case "11":
                    s = "23" + s;
                    break;
                case "12":
                    s = "12" + s;
                    break;
            }
        }
        else
        {
            s = s.Substring(0, s.Length - 2);
            if (hour == "12")
            {

                s = "00" + s.Substring(2);
            }

        }
        return s;

    }

}

class Solution
{
    public static void Main(string[] args)
    {


        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);


    }
}

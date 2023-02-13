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
    public static int[] matchingStrings(List<string> strings, List<string> queries)
    {
        int[] output = new int[queries.Count];
        foreach (string path in strings)
        {
            for (int i = 0; i < queries.Count; i++)
            {
                if (queries[i] == path)
                {
                    output[i]++;
                }
            }
        }

        return output;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        int[] res = Result.matchingStrings(strings, queries);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}

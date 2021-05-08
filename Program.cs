using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello World, Pravin!";
            //int vowel = 0, cons = 0, len = str.Length;

            //// convert string to lower and no need to check upper case characters

            //for (int i = 0; i < len; i++)
            //{
            //    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
            //    {
            //        vowel++;
            //    }
            //    else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            //    {
            //        cons++;
            //    }
            //}
            //Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
            //Console.Write("The total number of consonant in the string is : {0}\n\n", cons);


            ////reverse string ------------------------------------------------------------------------
            //char[] charArr = str.ToCharArray();
            //Array.Reverse(charArr);
            //Console.WriteLine(new string(charArr));

            //StringBuilder sb = new StringBuilder();
            //for (int i = str.Length-1; i >= 0; i--) 
            //{
            //    sb.Append(str[i]);
            //}
            //Console.WriteLine(sb.ToString());

            ////rotation string ------------------------------------------------------------------------------
            //string str1 = "abcde", str2 = "deabc";

            //if (str1.Length != str1.Length)
            //    Console.WriteLine("are not rotation");
            //else
            //{
            //    str1 = string.Concat(str1, str2);

            //    if (str1.IndexOf(str2) != -1)
            //        Console.WriteLine("Strings are rotation");
            //    else
            //        Console.WriteLine("Strings are not rotation");
            //}

            ////check is string digits ---------------------------------------------------------------------------------
            //string sss = "aa11";
            //bool isdigit = true;
            //foreach(char c in sss) 
            //{
            //    if (c < '0' || c > '9')
            //        isdigit = false;
            //}

            //if(isdigit)
            //Console.WriteLine("string is digit");
            //else
            //    Console.WriteLine("string is not digit");

            ////words anagrams of each other  Silent & Listen -----------------------------------------
            //string str1 = "Silent", str2 = "Listen";

            //if (str1.Length != str1.Length)
            //    Console.WriteLine("are not anagrams");
            //else
            //{
            //    char[] ch1 = str1.ToLower().ToCharArray();
            //    Array.Sort(ch1);
            //    char[] ch2 = str2.ToLower().ToCharArray();
            //    Array.Sort(ch2);

            //    str1 = new string(ch1);
            //    str2 = new string(ch2);
            //    if(str1 == str2)
            //        Console.WriteLine("are anagrams");
            //    else
            //        Console.WriteLine("are not anagrams");
            //}

            ////find duplicate characters in string -----------------------
            //string str = "googleOG";
            //StringBuilder sb = new StringBuilder();
            //str = str.ToLower();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = i + 1; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            if (!sb.ToString().Contains(str[i]))
            //            {
            //                sb.Append(str[i]);
            //                break;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Duplicat characters : " + sb.ToString());

            ////find characters number of occurence in string -----------------------
            //string str = "googleG";  // g - 3, o - 2, l - 1, e - 1
            //Dictionary<char, short> dict = new Dictionary<char, short>();
            //str = str.ToLower();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    short temp = 1;
            //    for (int j = i + 1; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //            temp++;
            //    }

            //    if (!dict.ContainsKey(str[i]))
            //        dict.Add(str[i], temp);
            //}

            //foreach (var d in dict)
            //    Console.WriteLine(d.Key + " -- "+ d.Value);

            ////Reverse each word of the sentence (string) ------------------------------------------------------------------
            /// i/p: Hi Pravin || o/p: iH nivarP
            //string str = "Hi Pravin Kumre";
            //string[] strArr = str.Split(' ');
            //StringBuilder sb = new StringBuilder();
            //foreach (var s in strArr) 
            //{
            //  char[] chaArr =  s.ToCharArray();
            //    Array.Reverse(chaArr);
            //    sb.Append(new string(chaArr) + " ");
            //}

            //Console.WriteLine(sb.ToString());

            ////Find word count of the sentence (string) ------------------------------------------------------------------
            //string str = "Hi, My Name is Pravin Kumre!";
            //Console.WriteLine(" No of words : " + str.Split(' ').Length);

            ////Check if a string is a palindrome or not. -------------------------------------
            ///i/p: naman
            //string str1 = "naman";
            //char[] charArr = str1.ToCharArray();
            //Array.Reverse(charArr);
            //string str2 = new string(charArr);
            //if (str1 == str2)
            //    Console.WriteLine("Polindrome");
            //else
            //    Console.WriteLine("Not Polindrome");


            //// Fibonacci Series ----------------------------------------
            /// o/p : 0, 1, 1, 2, 3, 5, 8, 13, 21
            //int num = 7, prev = 0, next = 1;
            //StringBuilder sb = new StringBuilder();
            //sb.Append(prev + ", " + next);

            //for (int i = 2; i <= num; i++)
            //{
            //    next = prev + next;
            //    sb.Append(", " + next);
            //    prev = next - prev;
            //}
            //Console.WriteLine(sb.ToString());

            ////second largest integer in an array using only one loop? ----------------------
            //int[] intArr = { 5, 7, 4, 8, 9 };
            //int Large = intArr[0], SecondLarge = 0;
            //foreach (int i in intArr)
            //{
            //    if (i > Large)
            //    {
            //        SecondLarge = Large;
            //        Large = i;
            //    }
            //}
            //Console.WriteLine("Second Large : " + SecondLarge.ToString());

            ////convert a two-dimensional array to a one-dimensional array? ----------------------------
            ///
            /////**** 1-D array column wise.
            //int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            //int index = 0;
            //int width = array.GetLength(0);
            //int height = array.GetLength(1);
            //int[] single = new int[width * height];
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        single[index] = array[x, y];
            //        Console.Write(single[index] + " ");
            //        index++;
            //    }
            //}

            //////**** 1-D array row wise.

            //int ind = 0;
            //int wdth = array.GetLength(0);
            //int hgt = array.GetLength(1);
            //int[] sing = new int[wdth * hgt];
            //for (int i = 0; i < wdth; i++)
            //{
            //    for (int j = 0; j < hgt; j++)
            //    {
            //        sing[ind] = array[i, j];
            //        Console.Write(sing[i] + " ");
            //        ind++;
            //    }
            //}
        }
    }
}

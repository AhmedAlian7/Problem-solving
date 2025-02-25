using System;
using System.Collections.Generic;

namespace Problem_Solving
{

    /*
                        ---------------------Problem---------------------
     
                Count Word Frequencies in a Text
                Problem: Count the frequency of each word in a given text.
                
                - Input: "hello world hello universe"
                - Output:
                
                    hello: 2
                
                    world: 1
                
    ﻿               universe: 1
     
     */

    public class Progam
    {
        public static Dictionary<string, int> WordFrequencies(string s)
        {
            var dic = new Dictionary<string, int>();
            var words = s.Split();
            foreach (var word in words)
            {
                if(dic.ContainsKey(word))
                {
                    dic[word]++;
                }
                else
                {
                    dic.Add(word, 1);
                }
            }
            return dic;
        }

        public static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            var dic = WordFrequencies(s);
            foreach (var word in dic)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
            }
        }
    }
}





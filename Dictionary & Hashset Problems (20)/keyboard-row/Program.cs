using System;
using System.Collections.Generic;

namespace Problem_Solving
{

    /*
                    -----------------Problem-----------------
     
                Find Words That Can Be Typed Using One Row of Keyboard

                Problem: Return all words that can be typed using one row of a QWERTY keyboard.
                
                Example:
                - Input: ["Hello", "Alaska", "Dad", "Peace"]
                - Output: ["Alaska", "Dad"]

     */

    public class Progam
    {
        static public string[] FindWords(string[] words)
        {
            var charsRowsMaping = FillMap();

            var res = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                
                var word = words[i];

                var first = charsRowsMaping[char.ToLower(word[0])];
                bool valid = true;

                for (int j = 1; j < word.Length; j++)
                {
                    if (first != charsRowsMaping[char.ToLower(word[j])])
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                    res.Add(word);
                
            }
            return res.ToArray();
        }
        static public Dictionary<char, int> FillMap()
        {
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            var dic = new Dictionary<char, int>();

            for (int i = 0; i < 3; i++)
            {
                foreach (var ch in rows[i])
                {
                    dic[ch] = i + 1;
                }
            }
            return dic;
        }

        public static void Main(string[] args)
        {
            var res = string.Join(",", FindWords(["adsdf", "sfd"]));
            Console.WriteLine($"[{res}]");
        }
    }
}





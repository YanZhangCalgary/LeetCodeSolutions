using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    public class KeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            var result = new List<string>();
            var keyboard = BuildKeyboard();
            foreach (string word in words)
            {
                var isOneRow = JudgeWord(word.ToLower(), keyboard);
                if (isOneRow)
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }

        Dictionary<int, string> BuildKeyboard()
        {
            Dictionary<int, string> keyboardMap = new Dictionary<int, string>();
            string row1 = "1234567890";
            var sRow1 = SortString(row1);
            keyboardMap.Add(1, sRow1);
            string row2 = "qwertyuiop";
            var sRow2 = SortString(row2);
            keyboardMap.Add(2, sRow2);
            string row3 = "asdfghjkl";
            var sRow3 = SortString(row3);
            keyboardMap.Add(3, sRow3);
            string row4 = "zxcvbnm";
            var sRow4 = SortString(row4);
            keyboardMap.Add(4, sRow4);
            return keyboardMap;
        }

        char[] SortChars(string s)
        {
            var chars = s.ToCharArray();
            Array.Sort(chars);
            return chars;
        }

        string SortString(string s)
        {
            var sortedChars = SortChars(s);
            return new string(sortedChars);
        }

        bool JudgeWord(string s, Dictionary<int, string> keyboardMap)
        {
            var word = RemoveDuplicateChars(s);
           
            foreach (KeyValuePair<int, string> pair in keyboardMap)
            {
                bool isOneRow = true;
                foreach (char value in word)
                {
                    isOneRow = isOneRow && pair.Value.Contains(value);
                }
                if (isOneRow) return true;
            }
            return false;
        }

        string RemoveDuplicateChars(string s)
        {
            string table = "";
            string result = ""; 
            foreach (char value in s)
            {
                if (table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}

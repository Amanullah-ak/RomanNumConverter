using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToIntegar
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            s = s.ToUpper();
            Dictionary<char, int> romanValues = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int result = 0;
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char currentChar = s[i];
                if (!romanValues.ContainsKey(currentChar))
                {
                    Console.WriteLine($"Invalid Roman numeral '{currentChar}'");
                    return -1;
                }
                int value = romanValues[currentChar];

                if (value < prevValue)
                {
                    result -= value;
                }
                else
                {
                    result += value;
                }

                prevValue = value;
            }

            return result;
        }
        
    }
}
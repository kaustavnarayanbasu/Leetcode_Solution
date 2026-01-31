using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solution
{
    internal class SmallestLetterGreterThanTerget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            foreach (char letter in letters)
            {
                if (letter > target)
                {
                    return letter;
                }
            }
            // If no character is greater, wrap around and return the first
            return letters[0];
        }

    }
}

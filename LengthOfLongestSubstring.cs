using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solution
{
    internal class LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            char[] findsting=s.ToCharArray();
            
            int IndexCount = 0;
            int maxLength = 0;
            SortedSet<string> uniqueNames = new SortedSet<string>();
            string temp = string.Empty;
            string[] finalString = new string[50000];
            for (int i= 0;i< findsting.Length-1;i++)
            {
                for (int j= i + 1;j< findsting.Length - 1;j++)
                {
                    if (findsting[i]!= findsting[j])
                    {
                        uniqueNames.Add(findsting[i].ToString());
                        uniqueNames.Add(findsting[j].ToString());
                        IndexCount++;
                        
                    }
                    else
                    {
                        //uniqueNames[IndexCount] = temp;
                        break;
                    }
                }
            }

        }
    }
}

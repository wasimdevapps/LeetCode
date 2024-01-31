using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Anagram
    {
        readonly static int CHARS = 26;
       public static int CountDeletions(String str1, String str2)
        {
            int[] arr = new int[CHARS];
            for (int i = 0; i < str1.Length; i++)
            {
                arr[str1[i] - 'a']++;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                arr[str2[i] - 'a']--;
            }

            int ans = 0;
            for (int i = 0; i < CHARS; i++)
            {
                ans += Math.Abs(arr[i]);
            }
            return ans;
        }
    }
}

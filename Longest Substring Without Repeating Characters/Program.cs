namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "pwwkew";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int maxLength = 0;
            HashSet<char> set = new HashSet<char>();

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}

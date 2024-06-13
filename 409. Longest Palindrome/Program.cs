namespace _409._Longest_Palindrome
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(LongestPalindrome("cabcacdd"));
		}
		public static int LongestPalindrome(string s)
		{
			var kvp = new Dictionary<char, int>();

			foreach (var item in s.ToCharArray())
			{
				if (kvp.ContainsKey(item))
					kvp[item]++;
				else
					kvp.Add(item, 1);
			}

			int res = 0;
			bool hasOdd = false;

			foreach (var item in kvp)
			{
				if (item.Value % 2 == 0)
				{
					res += item.Value;
				}
				else
				{
					res += item.Value - 1;
					hasOdd = true;
				}
			}

			if (hasOdd)
				return res + 1;

			return res;
		}
	}
}

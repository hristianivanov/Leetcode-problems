namespace _1._Two_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 3, 3 };
			int target = 6;

			Console.WriteLine(string.Join(" ", TwoSum(nums, target)));
		}

		public static int[] TwoSum(int[] nums, int target)
		{
			Dictionary<int, int> kvp = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				kvp[nums[i]] = i;
			}

			for (int i = 0; i < nums.Length; i++)
			{
				int complement = target - nums[i];

				if (kvp.ContainsKey(complement) &&
				    kvp[complement] != i)
				{
					return new int[] { kvp[complement], i };
				}
			}


			return null;
		}
	}
}

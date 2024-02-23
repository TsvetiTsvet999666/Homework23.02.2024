namespace DeleteNegativetems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove negative numbers!!! :");
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
            {
                if (nums[index] < 0)
                {
                    nums.RemoveAt(index);
                    index--;
                }
            }
            nums.Reverse();
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }

            }
        } 
    }
}

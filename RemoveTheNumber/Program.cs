namespace RemoveTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number on one line!! :");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int lastElement = numbers[numbers.Count - 1];
            for (int i  = 0; i < numbers.Count; i++)
            {
                numbers.Remove(lastElement);
            }
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}

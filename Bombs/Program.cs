namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine().Split() .Select(int.Parse).ToList();
            List<int> bombPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombPower[0];
            int power = bombPower[1];
            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i] == bomb)
                {
                    if (i + power > inputNums.Count - 1)
                    {
                        power = inputNums.Count - 1 - i;
                    }
                    inputNums.RemoveRange(i, power + 1);
                    power = bombPower[1];
                    int leftSide = i - power;
                    if (i - power < 0)
                    {
                        leftSide = 0;

                        if (power > inputNums.Count - 1)
                        {
                            power = inputNums.Count;
                        }

                    }
                    inputNums.RemoveRange(leftSide, power);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", inputNums.Sum()));
        }
    }
}
    


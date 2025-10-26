namespace CustomTupleIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var fruits = new string[] { "Apples", "Mangoes", "Bananas", "Grapes", "Rambutan" };

            var pairofArrays = new PairOfArrays<int, string>(numbers, fruits);

            //Console.WriteLine(pairofArrays[10, 2]); // out of range
            //Console.WriteLine(pairofArrays[2, 2]); // (3, Grapes)
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < fruits.Length; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"Before: Indexes ({i}, {j}) => Values {pairofArrays[i, j]}");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
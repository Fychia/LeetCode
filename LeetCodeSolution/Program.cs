namespace LeetCodeSolution;

internal class Program
{
    static void Main(string[] args)
    {
        var solution = new _1662.Solution();

        string[] word1 = { "ab", "c" };
        string[] word2 = { "a", "bc" };

        var result = solution.ArrayStringsAreEqual(word1,word2);

        Console.WriteLine(result);

    }
}
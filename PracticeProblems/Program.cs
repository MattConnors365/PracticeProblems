namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [2, 2, 2, 1, 2, 3, 2, 5, 2, 2];
            Console.WriteLine(MajorityElement.MyWay(list));
            Console.WriteLine(MajorityElement.BoyerMooreVotingAlgorithm(list));

            Console.ReadKey(true);
        }
    }
}

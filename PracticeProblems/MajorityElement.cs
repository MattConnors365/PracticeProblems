using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class MajorityElement
    {
        /*
         *   Majority Element
         * 
         * Input: a list
         * Output: the element of the list that appears more than half the times
         * 
         * Via https://www.interviewbit.com/problems/majority-element/
         */
        public static int MyWay(List<int> A) // O(n) time, O(n) space
        {
            int half = A.Count / 2;

            Dictionary<int, int> occurences = [];

            for (int i = 0; i < A.Count; i++)
            {
                int item = A[i];
                if (occurences.TryGetValue(item, out int value))
                {
                    occurences[item] = ++value;
                }
                else
                {
                    occurences.Add(item, 1);
                }
            }

            foreach (var (key, value) in occurences)
            {
                if (value > half)
                {
                    return key;
                }
            }

            throw new Exception($"List {A} does not contain a majority element.");
        }
        public static int BoyerMooreVotingAlgorithm(List<int> A)
        {
            int count = 0;
            int candidate = 0;

            // Step 1: Find candidate
            foreach (int num in A)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            // Step 2: Verify candidate
            int frequency = A.Count(x => x == candidate);
            if (frequency > A.Count / 2)
            {
                return candidate;
            }

            throw new Exception("No majority element exists.");
        }
    }
}

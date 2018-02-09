using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumList
{
    public class RandomNumberList
    {
        private const int MaxListSize = 10000;
        private static Random random = new Random(); //Used for random sorting

        public static List<int> MakeRandomList(int size)
        {
            //Code based off: 
            //https://codereview.stackexchange.com/questions/164919/generate-a-list-of-10-000-numbers-in-random-order
            //(first answer on page)
            List<int> randomList = Enumerable.Range(1, size).OrderBy(num => random.Next()).ToList();

            return randomList;
        }

        public static void Main(string[] args)
        {
            List<int> numList = MakeRandomList(MaxListSize);
            //Convert list to string and print to screen
            string listAsString = string.Join(", ", numList);
            Console.WriteLine(listAsString);
        }
    }
}

using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumList
{
    [TestFixture]
    public class RandomNumTest
    {
        [Test]
        public void CheckSizeOfList()
        {
            List<int> numList = RandomNumberList.MakeRandomList(10);
            Assert.AreEqual(numList.Count, 10);
        }

        [Test]
        public void CheckListForDistinctItems()
        {
            List<int> numList = RandomNumberList.MakeRandomList(100);
            IEnumerable<int> distinctNums = numList.Distinct();
            Assert.AreEqual(distinctNums.Count(), 100);
        }

        [Test]
        public void CheckItemsAreWithinRange()
        {
            List<int> numList = RandomNumberList.MakeRandomList(100);
            Assert.IsTrue(numList.TrueForAll(num => (num > 0 && num <= 100)));
        }

        [Test]
        public void CheckRandomOrder()
        {
            //There's a chance this will fail, even with 'true' randomness
            List<int> numList1 = RandomNumberList.MakeRandomList(100);
            List<int> numList2 = RandomNumberList.MakeRandomList(100);
            string listAsString1 = string.Join(", ", numList1);
            string listAsString2 = string.Join(", ", numList2);
            Assert.IsFalse(numList1.SequenceEqual(numList2));
        }

    }
}

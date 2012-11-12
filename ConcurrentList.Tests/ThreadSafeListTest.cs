using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ConcurrentList.Tests
{
    public class ThreadSafeListTest<TList> where TList : IList<int>, new()
    {
        [Test]
        public virtual void SuccessfullyAddsAllItemsFromConcurrentWrites()
        {
            var list = new TList();

            var options = new ParallelOptions
            {
                MaxDegreeOfParallelism = 8
            };

            Parallel.For(0, 10, options, i =>
            {
                for (int j = 0; j < 1000; ++j)
                {
                    list.Add((i * 1000) + j);
                }
            });

            Assert.That(list.Count, Is.EqualTo(10000));
            Assert.That(list, Is.EquivalentTo(Enumerable.Range(0, 10000)));
        }
    }
}

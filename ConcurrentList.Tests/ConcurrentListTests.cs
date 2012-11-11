using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using ConcurrentList;
using NUnit.Framework;

namespace ConcurrentList.Tests
{
    [TestFixture]
    public class ConcurrentListTests
    {
        [Test]
        public void AddedItemsAreStoredInList()
        {
            var list = new ConcurrentList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.That(list, Is.EquivalentTo(new[] { 1, 2, 3 }));
        }
        
        [Test]
        public void CountReflectsNumberOfItemsAdded()
        {
            var list = new ConcurrentList<int>();
            for (int i = 0; i < 1000; ++i)
            {
                list.Add(i);
            }
            Assert.That(list.Count, Is.EqualTo(1000));
        }
        
        [Test]
        public void SuccessfullyAddsAllItemsFromConcurrentWrites()
        {
            var list = new ConcurrentList<int>();
            
            var options = new ParallelOptions
            {
                MaxDegreeOfParallelism = 10
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

using System.Collections.Generic;

using NUnit.Framework;

namespace ConcurrentList.Tests
{
    [TestFixture]
    public class ListTests : ThreadSafeListTest<List<int>>
    {
        [Test]
        [Ignore("This test is EXPECTED to fail. To run, comment out or delete the 'Ignore' attribute.")]
        public override void SuccessfullyAddsAllItemsFromConcurrentWrites()
        {
            base.SuccessfullyAddsAllItemsFromConcurrentWrites();
        }
    }
}

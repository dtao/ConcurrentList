using System.Collections.Generic;

using NUnit.Framework;

namespace ConcurrentList.Tests
{
    [TestFixture]
    public class ListTests : ListTestsBase
    {
        [Test]
        [Ignore("This test is EXPECTED to fail. To run, comment out or delete the 'Ignore' attribute.")]
        public override void SuccessfullyAddsAllItemsFromConcurrentWrites()
        {
            base.SuccessfullyAddsAllItemsFromConcurrentWrites();
        }

        protected override IList<int> CreateList()
        {
            return new List<int>();
        }
    }
}

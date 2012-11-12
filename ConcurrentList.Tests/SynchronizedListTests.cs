using System.Collections.Generic;

using NUnit.Framework;

namespace ConcurrentList.Tests
{
    [TestFixture]
    public class SynchronizedListTests : ListTestsBase
    {
        protected override IList<int> CreateList()
        {
            return new SynchronizedList<int>();
        }
    }
}

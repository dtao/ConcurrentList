using NUnit.Framework;

namespace ConcurrentList.Tests
{
    [TestFixture]
    public class ConcurrentListTests : ThreadSafeListTest<ConcurrentList<int>>
    { }
}

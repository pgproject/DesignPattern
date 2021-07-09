using ExerciseAdapter;
using NUnit.Framework;

namespace TestSuite
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            var sq = new Square{Side = 11};
            var adapter = new SquareToRectangleAdapter(sq);
            Assert.That(adapter.Area(), Is.EqualTo(121));

        }
    }
}
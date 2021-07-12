using System.Collections.Generic;
using CompositeExercise;
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
            var sq = new Square {Side = 11};
            var adapter = new SquareToRectangleAdapter(sq);
            Assert.That(adapter.Area(), Is.EqualTo(121));
        }

        [Test]
        public void TestIntValue()
        {
            var singleValue = new SingleValue{Value = 11};
            var otherValues = new ManyValues();
            otherValues.Add(22);
            otherValues.Add(33);
            Assert.That(new List<IValueContainer>{singleValue, otherValues}.Sum(), Is.EqualTo(66));
        }
        

    }
}
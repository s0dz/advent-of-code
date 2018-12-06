using NUnit.Framework;

namespace Advent.Tests
{
    [TestFixture]
    public class AdventUtilityTests
    {
        [Test]
        public void ReadInput()
        {
            var result = AdventUtility.ReadInput("Day3TestInput.txt");
        }
    }
}

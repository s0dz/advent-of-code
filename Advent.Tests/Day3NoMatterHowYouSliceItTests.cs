using System.Linq;
using NUnit.Framework;

namespace Advent.Tests
{
    [TestFixture]
    public class Day3NoMatterHowYouSliceItTests
    {
        [Test]
        public void ReadAndMapInput_Test()
        {
            var result = Day3NoMatterHowYouSliceIt.ReadAndMapInput("Day3Input.txt");
        }


        [Test]
        public void GetSquareInchesOfOverlappingClaims_TestInput_Test()
        {
            var result = Day3NoMatterHowYouSliceIt.GetSquareInchesOfOverlappingClaims("Day3TestInput.txt");
        }

        [Test]
        public void GetSquareInchesOfOverlappingClaims_Input_Test()
        {
            var result = Day3NoMatterHowYouSliceIt.GetSquareInchesOfOverlappingClaims("Day3Input.txt");
        }

        [Test]
        public void GetLoneClaim_Input_Test()
        {
            var result = Day3NoMatterHowYouSliceIt.GetLoneClaim("Day3Input.txt").ToList();
        }
    }
}

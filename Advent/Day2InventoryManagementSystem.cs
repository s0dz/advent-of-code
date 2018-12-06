using System.Collections.Generic;
using System.Linq;

namespace Advent
{
    /*
     * https://adventofcode.com/2018/day/2
     */
    public class Day2InventoryManagementSystem
    {
        // https://en.wikipedia.org/wiki/Checksum
        public static int ChecksumFunction(List<string> inputs)
        {
            var twoCount = 0;
            var threeCount = 0;

            foreach (var input in inputs)
            {
                if (input.GroupBy(character => character).FirstOrDefault(character => character.Count() == 2 ) != null)
                {
                    twoCount++;
                }
                if (input.GroupBy(character => character).FirstOrDefault(character => character.Count() == 3) != null)
                {
                    threeCount++;
                }
            }

            return twoCount * threeCount;
        }

        // TODO: https://adventofcode.com/2018/day/2#part2
        public static string FindCommonLetters(List<string> inputs)
        {
            return null;
        }
    }
}

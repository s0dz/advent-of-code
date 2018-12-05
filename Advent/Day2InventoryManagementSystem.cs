using System.Collections.Generic;
using System.Linq;

namespace Advent
{
    public class Day2InventoryManagementSystem
    {
        /*
         * https://adventofcode.com/2018/day/2
         */
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
    }
}

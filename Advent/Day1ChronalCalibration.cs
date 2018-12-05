using System.Collections.Generic;

namespace Advent
{
    public class Day1ChronalCalibration
    {
        /*
         * https://adventofcode.com/2018/day/1
         */
        public static int CalibrateDevice(List<int> inputs)
        {
            // Starting frequency is zero
            var frequency = 0;

            foreach (var input in inputs)
            {
                frequency += input;
            }

            return frequency;
        }

        public static int FindDuplicateFrequency(List<int> inputs)
        {
            // Starting frequency is zero
            var frequency = 0;

            var frequencySet = new HashSet<int>{ frequency };

            while (true)
            {
                foreach (var input in inputs)
                {
                    frequency += input;
                    if (!frequencySet.Add(frequency))
                    {
                        return frequency;
                    }
                }
            }
        }
    }
}

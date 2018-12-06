using System.Collections.Generic;

namespace Advent
{
    public class AdventUtility
    {
        public static List<string> ReadInput(string filename)
        {
            string line;
            var lines = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader($"InputFiles/{filename}");
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }
            file.Close();

            return lines;
        }
    }
}

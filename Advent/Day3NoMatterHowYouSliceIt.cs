using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent
{
    /*
     * https://adventofcode.com/2018/day/3
     */
    public class Day3NoMatterHowYouSliceIt
    {
        // TODO: This gives correct answer but is dirt slow.
        public static int GetSquareInchesOfOverlappingClaims(string filename)
        {
            var area = 0;
            var coordinatesSet = new HashSet<Coordinates>();
            var alreadyCountedCoordinates = new List<Coordinates>();

            var claims = ReadAndMapInput(filename);

            foreach (var claim in claims)
            {
                for (var x = claim.X; x < claim.X + claim.Width; x++)
                {
                    for (var y = claim.Y; y < claim.Y + claim.Height; y++)
                    {
                        var coordinates = new Coordinates { X = x, Y = y };
                        if (!coordinatesSet.Add(coordinates) && !alreadyCountedCoordinates.Contains(coordinates))
                        {
                            area++;
                            alreadyCountedCoordinates.Add(coordinates);
                        }
                    }
                }
            }

            return area;
        }

        public static IEnumerable<int> GetLoneClaim(string filename)
        {
            var coordinatesSet = new HashSet<Coordinates>();
            var overlappingClaimIds = new List<int>();

            var claims = ReadAndMapInput(filename);

            foreach (var claim in claims)
            {
                for (var x = claim.X; x < claim.X + claim.Width; x++)
                {
                    for (var y = claim.Y; y < claim.Y + claim.Height; y++)
                    {
                        var coordinates = new Coordinates { X = x, Y = y };
                        if (!coordinatesSet.Add(coordinates) && !overlappingClaimIds.Contains(claim.Id))
                        {
                            overlappingClaimIds.Add(claim.Id);
                        }
                    }
                }
            }

            var claimIds = claims.Select(c => c.Id).ToList();

            return claimIds.Except(overlappingClaimIds);
        }

        public static List<Claim> ReadAndMapInput(string filename)
        {
            List<Claim> claims = new List<Claim>();

            var lines = AdventUtility.ReadInput(filename);

            foreach (var line in lines)
            {
                string[] words = line.Split(' ');

                var id = words[0].Trim('#');
                var xy = words[2].Trim(':').Split(',');
                var x = xy[0];
                var y = xy[1];
                var widthXHeight = words[3].Split('x');
                var width = widthXHeight[0];
                var height = widthXHeight[1];

                claims.Add(new Claim
                {
                    Id = Convert.ToInt32(id),
                    X = Convert.ToInt32(x),
                    Y = Convert.ToInt32(y),
                    Width = Convert.ToInt32(width),
                    Height = Convert.ToInt32(height)
                });
            }

            return claims;
        }
    }

    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Coordinates q && q.X == X && q.Y == Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }

    public class Claim
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}

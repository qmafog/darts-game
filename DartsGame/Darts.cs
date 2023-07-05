using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            double radius = (x * x) + (y * y);
            int res = 0;
            if (radius <= 1)
            {
                res += 10;
            }
            else if (radius <= 25)
            {
                res += 5;
            }
            else if (radius <= 100)
            {
                res += 1;
            }

            return res;
        }
    }
}

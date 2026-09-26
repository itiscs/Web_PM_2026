using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApp
{
    internal class Fitness
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int IdClient { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
            return $"{IdClient} - {Year} {Month} - {Hours}";
        }

        public static List<Fitness> GetClients()
        {
            var f = new List<Fitness>()
            {
                new Fitness { Month = 1, Year = 2026, IdClient = 101, Hours = 12 },
                new Fitness { Month = 2, Year = 2025, IdClient = 102, Hours = 15 },
                new Fitness { Month = 3, Year = 2026, IdClient = 103, Hours = 8 },
                new Fitness { Month = 4, Year = 2025, IdClient = 104, Hours = 20 },
                new Fitness { Month = 5, Year = 2026, IdClient = 102, Hours = 10 },
                new Fitness { Month = 6, Year = 2026, IdClient = 101, Hours = 14 },
                new Fitness { Month = 5, Year = 2025, IdClient = 106, Hours = 18 },
                new Fitness { Month = 8, Year = 2026, IdClient = 101, Hours = 6 },
                new Fitness { Month = 5, Year = 2026, IdClient = 106, Hours = 22 },
                new Fitness { Month = 10, Year = 2025, IdClient = 105, Hours = 11 }
            };
            return f;
        }
    }
}




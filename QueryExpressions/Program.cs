using ListMethods;

namespace QueryExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Winner> winnerList = new List<Winner>
            {
                new Winner("Argentina", new[] {1978, 1986, 2022}),
                new Winner("Brazil", new[] {1958, 1962, 1970, 1994, 2002}),
                new Winner("England", new[]{1970}),
                new Winner("France", new[]{1998, 2018}),
                new Winner("Germany", new[] {1954, 1974, 1990, 2014}),
                new Winner("Italy", new[]{1934, 1938, 1982, 2006}),
                new Winner("Spain", new[]{2010}),
                new Winner("Uruguay", new[]{1930, 1950}),
            };
            winnerList.Sort();
            Print(winnerList);

            IEnumerable<Winner> bestWinners =
                from winner in winnerList
                where winner.Years.Length >= 3
                orderby winner.Country ascending
                select winner;
            Print(bestWinners);
        }
        private static void Print<T>(IEnumerable<T> elems)
        {
            foreach (T elem in elems)
            {
                Console.WriteLine(elem);
            }
        }
    }
}

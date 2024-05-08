using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    internal class Winner : IComparable<Winner>
    {
        public string Country { get; set; }
        public int[] Years { get; set; }
        public Winner(string country, int[] years)
        {
            Country = country;
            Years = years;
        }
        public override string ToString()
        {
            string result = Country;
            foreach (int year in Years)
            {
                result += " " + year;
            }
            return result;
        }
        public int CompareTo(Winner? y)
        {
            if (y == null)
            {
                return 1;
            }
            else if (Years.Length != y.Years.Length)
            {
                return y.Years.Length - Years.Length;
            }
            else
            {
                return string.Compare(Country, y.Country);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    internal class Sorter
    {
        private int[] numbers;
        public Sorter(int[] inputArray)
        {
            numbers = (int[])inputArray.Clone();
        }

        public void SortDescending()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
        }

        public int[] GetSortedArray()
        {
            return (int[])numbers.Clone();
        }

    }
}

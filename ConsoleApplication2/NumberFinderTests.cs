using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApplication2
{
    [TestFixture]
    class NumberFinderTests
    {
        public IEnumerable<string> FindNumber(string numberToSearch, string number)
        {
            var indexOfNumber = number.IndexOf(numberToSearch);
            if (indexOfNumber == -1) return new List<string>();
            var nextSearchFirstIndex = indexOfNumber + numberToSearch.Length;
            if (nextSearchFirstIndex >= number.Length) return new List<string> {indexOfNumber.ToString() };

            var nextSearchNumber = number.Substring(nextSearchFirstIndex);
            var result = new List<string> {indexOfNumber.ToString() }
                .Concat(FindNumber(numberToSearch, nextSearchNumber).Select(x => int.Parse(x) + nextSearchFirstIndex).Select(x=>x.ToString()));
            return result;
        }

        [TestCase(2, 542, "2")]
        [TestCase(2, 242, "02")]
        [TestCase(2, 222, "012")]
        [TestCase(2, 24242, "024")]
        [TestCase(2, 133, "")]
        [TestCase(23223, 133, "")]
        [TestCase(0, 103, "1")]
        [TestCase(0, 113, "")]
        [TestCase(1, 101, "02")]
        [TestCase(0, 10003, "123")]
        public void NumberFinder(int numberToSearch, long number, string result)
        {
            var indexes = FindNumber(numberToSearch.ToString(), number.ToString());
            var indexesAsString = string.Join("", indexes);
            Assert.AreEqual(result, indexesAsString);
        }
       
    }
}

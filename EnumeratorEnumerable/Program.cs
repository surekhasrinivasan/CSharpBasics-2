using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oyears = new List<int>();
            oyears.Add(1990);
            oyears.Add(1991);
            oyears.Add(1992);
            oyears.Add(1993);
            oyears.Add(2001);
            oyears.Add(2002);
            oyears.Add(2003);

            IEnumerable<int> ienum = (IEnumerable<int>)oyears;
            
            foreach(int i in ienum)
            {
                Console.WriteLine(i);
            }
                Console.WriteLine();

            IEnumerator<int> ienumerat = oyears.GetEnumerator();

            while (ienumerat.MoveNext())
            {
                Console.WriteLine(ienumerat.Current.ToString());
            }
            Console.ReadLine();
        }
    }
}

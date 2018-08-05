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
            Iterate1990to2001(ienum);
            
            //foreach(int i in ienum)
            //{
            //    Console.WriteLine(i);
            //}
            //    Console.WriteLine();

            //IEnumerator<int> ienumerat = oyears.GetEnumerator();
            //Iterate1990to2001(ienumerat);



            //while (ienumerat.MoveNext())
            //{
            //    Console.WriteLine(ienumerat.Current.ToString());
            //}
            Console.ReadLine();
        }

        //static void Iterate1990to2001(IEnumerator<int> o)
        //{
        //    //iterate value from 1990 to 2001
        //    while(o.MoveNext())
        //    {
        //        Console.WriteLine(o.Current.ToString());
        //        if(Convert.ToInt16(o.Current) > 2000)
        //        {
        //            Iterate2001andAbove(o);
        //        }
        //    }
        //}

        //static void Iterate2001andAbove(IEnumerator<int> o)
        //{
        //    //iterate value from 2001 and above 
        //    while(o.MoveNext())
        //    {
        //        Console.WriteLine(o.Current.ToString());
        //    }
        //}

        static void Iterate1990to2001(IEnumerable<int> o)
        {
            //iterate value from 1990 to 2001
            foreach(int i in o)
            {
                Console.WriteLine(i);
                if (i > 2000)
                {
                    Iterate2001andAbove(o);
                }
            }
        }

        static void Iterate2001andAbove(IEnumerable<int> o)
        {
            foreach(int i in o)
            {
                Console.WriteLine(i);
            }
        }

    }
}

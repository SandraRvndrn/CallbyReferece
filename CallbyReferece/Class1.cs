using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbyReference
{
    public class Class1
    {

        static void Main(string[] args)
        {
            abc a1, a2 = new abc(), a3 = new abc(), a4;

            a2.i = 1;
            a3.i = 2;
            a1 = a3;
            a4 = a2;
            a1.i = 3;
            a2.i = 4;
            Console.WriteLine(a1.i);
            Console.WriteLine(a2.i);
            Console.WriteLine(a3.i);
            Console.WriteLine(a4.i);

            Console.ReadKey();
        }
    }
    public class abc
    {
        public int i;
    }
}

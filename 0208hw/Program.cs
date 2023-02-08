using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 2, 3);
            Vector b = new Vector(1, 2, 3);
            Vector c = new Vector();
            double scalar = 3;
            a.Print();
            b.Print();
            Console.WriteLine("Length: " + a.Length());
            Console.WriteLine("Length: " + b.Length());
            Console.WriteLine("Equal? "+a.AreEqual(b));
            Console.WriteLine("a+b? " + a.VectorPlus(b));
            Console.WriteLine("a-b? " + a.VectorMinus(b));
            c = a.VectorMult(b);
            Console.Write("a*b? ");
            c.Print();
            Console.Write("a-"+scalar+"? ");
            a.ScalarMinus(scalar);
            Console.Write("a+" + scalar + "? ");
            a.ScalarPlus(scalar);

        }
    }
}

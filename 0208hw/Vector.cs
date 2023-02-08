using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208hw
{
    class Vector
    {
        private double x;
        private double y;
        private double z;
        public Vector() : this(0,0,0){}
        public Vector(double _x) : this(_x,0, 0){}
        public Vector(double _x,double _y,double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public void Input()
        {
            Console.WriteLine("x?");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y?");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("z?");
            z = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("x: " + x + " y: " + y + " z: " + z);
        }
        public double X 
        {
            get => x;
        }
        public double Y
        {
            get => y;
        }
        public double Z 
        {
            get => z;
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        public void ScalarPlus(double scalar)
        {
            Console.WriteLine("x: " + (x + scalar) + " y: " + (y + scalar) + " z: " + (z + scalar));
        }
        public void ScalarMinus(double scalar)
        {
            Console.WriteLine("x: " + (x - scalar) + " y: " + (y - scalar) + " z: " + (z - scalar));
        }
        public bool AreEqual(Vector vector)
        {
            if (this.Length() == vector.Length())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double VectorPlus(Vector vector)
        {
            return ((this.x + vector.x) * (this.y + vector.y) * (this.z + vector.z));
        }
        public double VectorMinus(Vector vector)
        {
            return ((this.x - vector.x) * (this.y - vector.y) * (this.z - vector.z));
        }
        public Vector VectorMult(Vector vector)
        {
            Vector result = new Vector(this.x * vector.x, this.y * vector.y, this.z * vector.z);
            return result;
        }
    }
}

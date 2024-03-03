using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    internal class Vettore
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vettore(double vx, double vy)
        {
            X = vx;
            Y = vy;
        }

        public static Vettore operator *(Vettore a, double b)
        {
            return new Vettore(a.X * b, a.Y * b);
        }
        public static Vettore operator *(double a, Vettore b)
        {
            return new Vettore(b.X * a, b.Y * a);
        }
        public static Vettore operator +(Vettore a, Vettore b)
        {
            return new Vettore(a.X + b.X, a.Y + b.Y);
        }
        public static Vettore operator -(Vettore a, Vettore b)
        {
            return new Vettore(a.X - b.X, a.Y - b.Y);
        }
        public static Vettore operator /(Vettore a, double b)
        {
            return new Vettore(a.X / b, a.Y / b);
        }
        public static Vettore operator +(Vettore a)
        {
            return new Vettore(a.X, a.Y);
        }
        public static Vettore operator -(Vettore a )
        {
            return new Vettore(-a.X, -a.Y);
        }
        public static Vettore operator *(Vettore a, Vettore b )
        {
            return a * b;   
        }



    }
}
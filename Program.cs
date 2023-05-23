using System;
using System.Globalization;

namespace Course
{

    public class Triangulo
    { 
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; } 

        public double CalcularArea()
        {
            double p = (A + B + C)/2.0;
            double area = Math.Sqrt(p *(p - A) * (p - B) * (p - C));
            return area;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");

            double areax = x.CalcularArea();
            double areay = y.CalcularArea();

            Console.WriteLine("Area de X: " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("Area de X é maior ");
            }
            else
            {
                Console.WriteLine("Area de Y é maior ");
            }
        }
        public static Triangulo LerTriangulo(string nomeTriangulo)
        { 
            Triangulo tri = new Triangulo();
            Console.WriteLine("Entre com os valores do triangulo " + nomeTriangulo);
            tri.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tri.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tri.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return tri;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_6
{
    public class Equilateral
    {
        private Triangle triangle;
        private double area;
        static int counter1 = 0;
        public class Triangle
        {
            private int A;
            private int B;
            private int C;
            private static int counter2 = 0;


            public int Get_A() { return A; }
            public int Get_B() { return B;}
            public int Get_C() { return C;}
            public static int GetCounter() { return counter2; }
            public bool Set_A(int value)
            {
                if (value > 0) { this.A = value; return true; }
                else { this.A = 0; return false; }
            
            }
            public bool Set_B(int value)
            {
                if (value > 0) { this.B = value; return true; }
                else { this.B = 0; return false; }

            }
            public bool Set_C(int value)
            {
                if (value > 0) { this.C = value; return true; }
                else { this.C = 0; return false; }

            }
            public bool Init(int a, int b, int c){return Set_A(a) && Set_B(b) && Set_C(c);}
            public Triangle() { this.A = 0;this.B=0;this.C = 0; counter2++; }
                     
            public Triangle(int a, int b, int c ){this.Init(a, b, c); counter2++; }
            public Triangle(Triangle t) { this.A = t.A; this.B = t.B; this.C = t.C; counter2++; }
            public int Perimeter(){ return this.A + this.B + this.C;}
            public void Angle()
            {
                int a = this.A;
                int b = this.B;
                int c = this.C;
                double a2 = Math.Pow(a, 2);
                double b2 = Math.Pow(b, 2);
                double c2 = Math.Pow(c, 2);

                double alpha = Math.Acos((b2 + c2 - a2) /(2 * b * c));
                double betta = Math.Acos((a2 + c2 - b2) / (2 * a * c));
                double gamma = Math.Acos((a2 + b2 - c2) / (2 * a * b));

                alpha = Math.Round((alpha * 180 / Math.PI), 0);
                betta = Math.Round((betta * 180 / Math.PI), 0);
                gamma = Math.Round((gamma * 180 / Math.PI),0);

                Console.WriteLine(" alpha: {0}\n betta: {1}\n gamma: {2}\n ", alpha,betta,gamma);


            }
            public void Display(){ Console.WriteLine(" A: {0}\n B: {1}\n C: {2}\n Perimeter = {3}", this.A, this.B,this.C,this.Perimeter());this.Angle();}
            public void Read()
            {      
                int a,b,c;
                do
                {
                    Console.Write("A: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("B: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("C: ");
                    c = Convert.ToInt32(Console.ReadLine());
                } while (!Init(b,b,c));
            }
            public override string ToString()
            {
                return "Triangle: [A: " + this.A + ", "
                + "B: " + this.B + ", " + "C: " + this.C + "]";
            }

        }
        public double Area(Triangle t)
        {
            int p;
            int a = t.Get_A();
            int b = t.Get_B();
            int c = t.Get_C();
            p = (a+b+c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Math.Round(S,2);

        }
        public Triangle GetTriangle() { return this.triangle; }
        public double GetArea() { return this.area; }   
        public static int GetCounter() { return counter1; }
        public bool Init(Triangle t) 
        {
            if (t.Get_A() == t.Get_B() || t.Get_A() == t.Get_C() || t.Get_C() == t.Get_B())
                return true;
            else
                return false;
        }
        public Equilateral()
        {
            this.triangle = new Triangle();
            this.area = 0;
            counter1++;
        }
        public Equilateral(Triangle t)
        {
                
               this.triangle = new Triangle(t);
               this.area = Area(t);
               counter1++; 
           
        }
        public Equilateral(Equilateral t)
        {
            this.triangle = t.triangle;
            this.area = t.area;
            counter1++;
        }
        public void Display()
        {  
            this.triangle.Display();
            Console.WriteLine(" Area: {0}", this.area);
        }

        public void Read()
        {
            Triangle t = new Triangle();
            int a, b, c;
            do
            {
                Console.Write("A: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("C: ");
                c = Convert.ToInt32(Console.ReadLine());
                t.Set_A(a);
                t.Set_B(b);
                t.Set_C(c);     
            } while (!Init(t));
            this.triangle = t;
            this.area = Area(t);
        }

    }
}

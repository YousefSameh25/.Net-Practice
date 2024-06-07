namespace operator_overload
{
    class complex
    {
        public int real { get; set; }
        public int img { get; set; }

        // Must be static, why? to provide an option to create function takes for ex(5, c1)
        public static complex operator + (complex c1, complex c2)
        {
            complex res = new complex();
            res.real = c1.real + c2.real;
            res.img = c1.img + c2.img;
            return res;
        }

        public static complex operator +(int real, complex c1)
        {
            complex res = new complex();
            res.real = real + c1.real;
            res.img = c1.img;
            return res;
        }

        // If i implemented '==' so i have to implement '!=', why?
        // as in normal == compare references and if you did not implement '!=' that means 
        // the '==' and '!=' may be both true at the same time.
        public static bool operator ==(complex c1, complex c2)
        {
            return (c1.real == c2.real && c1.img == c2.img);
        }

        public static bool operator !=(complex c1, complex c2)
        {
            return (c1.real != c2.real || c1.img != c2.img);
        }

        // Implicit casting operator overload (complex c = 10).
        public static implicit operator complex(int real)
        {
            complex c = new complex();
            c.real = real;
            return c;
        }

        // Explicit casting operator overload (int x = (complex) c).
        public static explicit operator int(complex c)
        {
            return c.real;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            complex c1 = new complex { real = 10, img = 5 };
            complex c2 = new complex { real = 6, img = 4 };

            complex c3 = c1 + c2;

            complex c4 = 5 + c3;

            // (implicit casting), we can remove the public static complex operator +(int real, complex c1)
            // as compiler could implicit cast the int and call the public static complex operator +(complex c1, complex c2)
            complex c5 = 10;

            // (Explicit casting) not unboxing.
            int num = (int) c5;

            // Note the operator '=' can not be overload as it mat lead to many problems.

            // Read about operator '++' overload ((post, pre)fix)
        }
    }
}
